/* Write a function that replaces non breaking white-spaces in a text with &nbsp; */
(function () {
    function replaceWhitespace (text) {
        while (text.indexOf(' ') != -1) {
            text = text.replace(' ', '&nbsp;');
        }
        return text;
    }

    var text = 'Lorem ipsum dolor sit amet.';
    text = replaceWhitespace(text);
    console.log(text);
})();