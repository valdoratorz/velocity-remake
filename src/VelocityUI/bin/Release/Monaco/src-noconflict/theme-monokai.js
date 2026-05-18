ace.define("ace/theme/monokai", ["require", "exports", "module", "ace/lib/dom"], function (require, exports, module) {

    exports.isDark = true;
    exports.cssClass = "ace-monokai";
    exports.cssText = `
.ace-monokai .ace_gutter {
    background: rgb(16,16,16);
    color: #8F908A;
}
.ace-monokai .ace_print-margin {
    width: 1px;
    background: rgb(20,20,20);
}
.ace-monokai {
    background-color: rgb(16, 16, 16);
    color: #F8F8F2;
}
.ace-monokai .ace_cursor {
    color: #F8F8F0;
}
.ace-monokai .ace_marker-layer .ace_selection {
    background: #49483E;
}
.ace-monokai.ace_multiselect .ace_selection.ace_start {
    box-shadow: 0 0 3px 0px #272822;
}
.ace-monokai .ace_marker-layer .ace_step {
    background: rgb(102, 82, 0);
}
.ace-monokai .ace_marker-layer .ace_bracket {
    margin: -1px 0 0 -1px;
    border: 1px solid #49483E;
}
.ace-monokai .ace_marker-layer .ace_active-line {
    background: #202020;
}
::-webkit-scrollbar {
    width: 8px;
    border-radius: 2;
    height: 8px;
}
::-webkit-scrollbar-track {
    background: rgb(17, 17, 17);
}
::-webkit-scrollbar-thumb {
    background: #888;
}
::-webkit-scrollbar-thumb:hover {
    background: #555;
}
.ace-monokai .ace_gutter-active-line {
    background-color: rgb(20, 20, 20);
}
.ace-monokai .ace_marker-layer .ace_selected-word {
    border: 1px solid #49483E;
}
.ace-monokai .ace_invisible {
    color: #52524d;
}
.ace-monokai .ace_entity.ace_name.ace_tag,
.ace-monokai .ace_keyword,
.ace-monokai .ace_meta.ace_tag,
.ace-monokai .ace_storage {
    color: #F97583;
}
.ace-monokai .ace_punctuation,
.ace-monokai .ace_punctuation.ace_tag {
    color: #fff;
}
.ace-monokai .ace_constant.ace_character,
.ace-monokai .ace_constant.ace_language,
.ace-monokai .ace_constant.ace_numeric,
.ace-monokai .ace_constant.ace_other {
    color: #AE81FF;
}
.ace-monokai .ace_invalid {
    color: #F8F8F0;
    background-color: #F92672;
}
.ace-monokai .ace_invalid.ace_deprecated {
    color: #F8F8F0;
    background-color: #AE81FF;
}
.ace-monokai .ace_support.ace_constant,
.ace-monokai .ace_support.ace_function {
    color: #79B8FF;
}
.ace-monokai .ace_fold {
    background-color: #A6E22E;
    border-color: #F8F8F2;
}
.ace-monokai .ace_storage.ace_type,
.ace-monokai .ace_support.ace_class,
.ace-monokai .ace_support.ace_type {
    font-style: italic !important;
    color: #66D9EF;
}
.ace-monokai .ace_entity.ace_name.ace_function,
.ace-monokai .ace_entity.ace_other,
.ace-monokai .ace_entity.ace_other.ace_attribute-name,
.ace-monokai .ace_variable {
    color: #79B8FF;
}
.ace-monokai .ace_variable.ace_parameter {
    font-style: italic !important;
    color: #6FDBDF;
}
.ace-monokai .ace_string {
    color: #9ECBFF;
}
.ace-monokai .ace_comment {
    color: #6A737D;
}
.ace-monokai .ace_indent-guide {
    background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAACCAYAAACZgbYnAAAAEklEQVQImWPQ0FD0ZXBzd/wPAAjVAoxeSgNeAAAAAElFTkSuQmCC) right repeat-y;
}
        .ace-monokai .keyword { color: #F97583; }
        .ace-monokai .string { color: #9ECBFF; }
        .ace-monokai .variable { color: #B392F0; }
        .ace-monokai .function { color: #79B8FF; }
        .ace-monokai .comment { color: #6A737D; }
        .ace-monokai .number { color: #9ECBFF; }
    `;

    var dom = require("../lib/dom");
    dom.importCssString(exports.cssText, exports.cssClass, false);
});

(function () {
    ace.require(["ace/theme/monokai"], function (m) {
        if (typeof module === "object" && typeof exports === "object" && module) {
            module.exports = m;
        }
    });
})();
