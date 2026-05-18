using FluentTransitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelocityUI
{
    public partial class Form1 : Form
    {


        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16; 
        private const int HTBOTTOMRIGHT = 17;
        private const int BorderWidth = 10;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(796, 448);
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

               
                if (this.WindowState == FormWindowState.Maximized)
                {
                    return;
                }

                if ((int)m.Result == HTCLIENT)
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = this.PointToClient(screenPoint);
                    if (clientPoint.Y <= BorderWidth)
                    {
                        if (clientPoint.X <= BorderWidth)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (clientPoint.X < (Size.Width - BorderWidth))
                            m.Result = (IntPtr)HTTOP;
                        else
                            m.Result = (IntPtr)HTTOPRIGHT;
                    }
                    else if (clientPoint.Y <= (Size.Height - BorderWidth))
                    {
                        if (clientPoint.X <= BorderWidth)
                            m.Result = (IntPtr)HTLEFT;
                        else if (clientPoint.X > (Size.Width - BorderWidth))
                            m.Result = (IntPtr)HTRIGHT;
                    }
                    else
                    {
                        if (clientPoint.X <= BorderWidth)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else if (clientPoint.X < (Size.Width - BorderWidth))
                            m.Result = (IntPtr)HTBOTTOM;
                        else
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                    }
                }
                return;
            }
            base.WndProc(ref m);
        }
        private async void exitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Close VelocityRemake?", "Velocity", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            Environment.Exit(0);
            await Task.Delay(1000);
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.MaximizedBounds = workingArea;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            string monaco = Path.Combine(Application.StartupPath, "Monaco", "ace.html");
            string monaco2 = new Uri(monaco).AbsoluteUri;
            webView21.CoreWebView2.Navigate(monaco2);
            StartupPanel.Top = 0;
            await Task.Delay(1000);
            Transition.With(StartupPanel, nameof(StartupPanel.Top), -1000).EaseInEaseOut(TimeSpan.FromMilliseconds(2300));
        }
        public void settext(string text)
        {
            string sanitizedText = text;
            sanitizedText = SanitizeString(sanitizedText);
            webView21.CoreWebView2.ExecuteScriptAsync($"setText('{sanitizedText}')");
        }
        public async Task<string> gettext()
        {
            try
            {
                var scriptResult = await webView21.CoreWebView2.ExecuteScriptAsync("getText()");

                scriptResult = JsonSerializer.Deserialize<string>(scriptResult);

                scriptResult = SanitizeString(scriptResult);

                return scriptResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving text: " + ex.Message);
                return string.Empty;
            }
        }

        private string SanitizeString(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            input = input.Replace("\\\"", "\"");
            input = input.Replace("\\'", "'");
            input = input.Replace("`", "");

            input = Regex.Replace(input, @"[\x00-\x08\x0B\x0C\x0E-\x1F\x7F]", "");

            return input.Trim();
        }

        public void ToggleMinimap(bool enable)
        {
            webView21.CoreWebView2.ExecuteScriptAsync($"SwitchMinimap({enable.ToString().ToLower()})");
        }
        public void ChangeFontSize(int fontSize)
        {
            webView21.CoreWebView2.ExecuteScriptAsync($"SwitchFontSize({fontSize})");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            gettext().ContinueWith(task =>
            {
                string result = task.Result;
                this.Invoke((MethodInvoker)delegate
                {
                    SaveFileDialog saveFileDialog1x = new SaveFileDialog();
                    saveFileDialog1x.Filter = "Text (*.txt)|*.txt";
                    saveFileDialog1x.DefaultExt = "txt";
                    saveFileDialog1x.InitialDirectory = Path.Combine(Application.StartupPath, "scripts");

                    if (saveFileDialog1x.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1x.FileName, result);
                    }
                });
            });
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1x = new OpenFileDialog();
            openFileDialog1x.Filter = "Text (*.txt)|*.txt";
            openFileDialog1x.DefaultExt = "txt";
            openFileDialog1x.InitialDirectory = Path.Combine(Application.StartupPath, "scripts");

            if (openFileDialog1x.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog1x.FileName);
                settext(text);

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            settext("");
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "Injector.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process.Start(startInfo);
        }

        private static async Task SendScript(string script)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "skibiditoiletisbadbutawpisgood", PipeDirection.Out))
            {
                try
                {
                    await pipeClient.ConnectAsync();
                    if (pipeClient.IsConnected)
                    {
                        Console.WriteLine("Pipe connected successfully.");

                        byte[] scriptBytes = Encoding.UTF8.GetBytes(script);
                        await pipeClient.WriteAsync(scriptBytes, 0, scriptBytes.Length);
                        Console.WriteLine("Script sent successfully.");

                        scriptBytes = (byte[])null;
                    }
                    else
                    {
                        Console.WriteLine("Pipe connection failed.");
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending the script: " + ex.Message, "Error");
                }
            }
        }

        private void executeBtn_Click_1(object sender, EventArgs e)
        {
            gettext().ContinueWith(async task =>
            {
                string result = task.Result;
                await SendScript(result);
            });
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void StartupPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
