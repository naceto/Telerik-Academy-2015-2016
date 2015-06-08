/*
 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
*/

(function () {

    function returnAsString (input) {
        return input.toString();
    }

    function stringFormat(format) {
        var arg = [].slice.apply(arguments),
            i,
            len,
            index,
            placeholder,
            lastIndex = 0,
            resultStr = '';

        for (i = 0, len = arg.length; i < len; i += 1) {
            placeholder = '{' + i + '}';
            resultStr = '';
            while ((index = format.indexOf (placeholder, index)) != -1) {
                resultStr += format.substring(lastIndex, index);
                resultStr += returnAsString(arg[i + 1]);
                lastIndex = index + placeholder.length;
                index += 1;
            }
            resultStr += format.substring(lastIndex);
            lastIndex = 0;
            index = 0;
            format = resultStr;
        }
        return resultStr;
    }
    var frmt = '{3} {0}, {1}, {0} text {2} {3} {3} {3} qaa';
    var str = stringFormat(frmt, 1, 'Pesho', 'Gosho', 'ENG');
    console.log (str);
})();