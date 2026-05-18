namespace VelocityUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.maximizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StartupPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.StartupLogo = new System.Windows.Forms.PictureBox();
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.openBtn = new Guna.UI2.WinForms.Guna2Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.injectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.executeBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartupLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VelocityUI.Properties.Resources.velocity_executor_logo_enhanced_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Animated = true;
            this.minimizeBtn.AnimatedGIF = true;
            this.minimizeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.minimizeBtn.BorderRadius = 10;
            this.minimizeBtn.BorderThickness = 1;
            this.minimizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minimizeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeBtn.Image = global::VelocityUI.Properties.Resources.icons8_line_96;
            this.minimizeBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.minimizeBtn.Location = new System.Drawing.Point(698, 5);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(27, 27);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.Animated = true;
            this.maximizeBtn.AnimatedGIF = true;
            this.maximizeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.maximizeBtn.BorderRadius = 10;
            this.maximizeBtn.BorderThickness = 1;
            this.maximizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maximizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maximizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maximizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.maximizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.maximizeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.maximizeBtn.Image = global::VelocityUI.Properties.Resources.icons8_square_48;
            this.maximizeBtn.ImageSize = new System.Drawing.Size(17, 17);
            this.maximizeBtn.Location = new System.Drawing.Point(731, 5);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(27, 27);
            this.maximizeBtn.TabIndex = 1;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Animated = true;
            this.exitBtn.AnimatedGIF = true;
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.exitBtn.BorderRadius = 10;
            this.exitBtn.BorderThickness = 1;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBtn.Image = global::VelocityUI.Properties.Resources.icons8_x_48;
            this.exitBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.exitBtn.Location = new System.Drawing.Point(764, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 27);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StartupPanel
            // 
            this.StartupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartupPanel.Controls.Add(this.StartupLogo);
            this.StartupPanel.Location = new System.Drawing.Point(0, 0);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(796, 448);
            this.StartupPanel.TabIndex = 16;
            this.StartupPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartupPanel_Paint);
            // 
            // StartupLogo
            // 
            this.StartupLogo.Image = global::VelocityUI.Properties.Resources.velocity_executor_logo_enhanced_Photoroom;
            this.StartupLogo.Location = new System.Drawing.Point(353, 160);
            this.StartupLogo.Name = "StartupLogo";
            this.StartupLogo.Size = new System.Drawing.Size(90, 90);
            this.StartupLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartupLogo.TabIndex = 17;
            this.StartupLogo.TabStop = false;
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.EnhanceCorners = true;
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiFormRounder1.Rounding = 8;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openBtn.Animated = true;
            this.openBtn.AnimatedGIF = true;
            this.openBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBtn.BorderRadius = 6;
            this.openBtn.BorderThickness = 1;
            this.openBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.openBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.openBtn.ImageOffset = new System.Drawing.Point(4, -1);
            this.openBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.openBtn.Location = new System.Drawing.Point(210, 407);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(95, 34);
            this.openBtn.TabIndex = 13;
            this.openBtn.Text = "Open";
            this.openBtn.TextOffset = new System.Drawing.Point(10, -1);
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(7, 45);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(784, 356);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click_1);
            // 
            // injectBtn
            // 
            this.injectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.injectBtn.Animated = true;
            this.injectBtn.AnimatedGIF = true;
            this.injectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.injectBtn.BorderRadius = 6;
            this.injectBtn.BorderThickness = 1;
            this.injectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.injectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.injectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.injectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.injectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.injectBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.injectBtn.ForeColor = System.Drawing.Color.White;
            this.injectBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.injectBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.injectBtn.Image = ((System.Drawing.Image)(resources.GetObject("injectBtn.Image")));
            this.injectBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.injectBtn.ImageOffset = new System.Drawing.Point(4, -1);
            this.injectBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.injectBtn.Location = new System.Drawing.Point(695, 407);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(95, 34);
            this.injectBtn.TabIndex = 8;
            this.injectBtn.Text = "Inject";
            this.injectBtn.TextOffset = new System.Drawing.Point(10, -1);
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Animated = true;
            this.clearBtn.AnimatedGIF = true;
            this.clearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clearBtn.BorderRadius = 6;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clearBtn.ImageOffset = new System.Drawing.Point(3, -1);
            this.clearBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.clearBtn.Location = new System.Drawing.Point(109, 407);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(95, 34);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextOffset = new System.Drawing.Point(8, -1);
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Animated = true;
            this.saveBtn.AnimatedGIF = true;
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveBtn.BorderRadius = 6;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveBtn.ImageOffset = new System.Drawing.Point(5, -1);
            this.saveBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.saveBtn.Location = new System.Drawing.Point(311, 407);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(95, 34);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextOffset = new System.Drawing.Point(10, -1);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.executeBtn.Animated = true;
            this.executeBtn.AnimatedGIF = true;
            this.executeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.executeBtn.BorderRadius = 6;
            this.executeBtn.BorderThickness = 1;
            this.executeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.executeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.executeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.executeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.executeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.executeBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.executeBtn.ForeColor = System.Drawing.Color.White;
            this.executeBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.executeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.executeBtn.Image = ((System.Drawing.Image)(resources.GetObject("executeBtn.Image")));
            this.executeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.executeBtn.ImageSize = new System.Drawing.Size(17, 17);
            this.executeBtn.Location = new System.Drawing.Point(7, 407);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(96, 34);
            this.executeBtn.TabIndex = 9;
            this.executeBtn.Text = "Execute";
            this.executeBtn.TextOffset = new System.Drawing.Point(11, -1);
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.StartupPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartupLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button minimizeBtn;
        private Guna.UI2.WinForms.Guna2Button maximizeBtn;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel StartupPanel;
        private System.Windows.Forms.PictureBox StartupLogo;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button openBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button executeBtn;
        private Guna.UI2.WinForms.Guna2Button injectBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

