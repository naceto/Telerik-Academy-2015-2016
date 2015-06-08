/* Write a JavaScript function to check if in a given expression the brackets are put correctly. Example of correct
expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)). */

(function () {
    function checkBrackets (string) {
        var i = 0,
            len = string.length,
            bracketsCount = 0;
        while (i < len) {
            var c = string[i];

            if (c === '(') {
                bracketsCount += 1;
            }
            if (c === ')') {
                bracketsCount -= 1;
            }
            if (bracketsCount < 0) {
                return false;
            }
            i += 1;
        }
        return bracketsCount === 0;
    }

    var expression = '((a+b)/5-d)';
    console.log(checkBrackets(expression));
})();