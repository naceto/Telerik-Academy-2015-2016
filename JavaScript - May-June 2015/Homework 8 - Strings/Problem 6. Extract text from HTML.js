/*  Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

(function () {
    function transformText(text, how) {
        switch (how) {
            case 'u':
                return text.toUpperCase();
            case 'l':
                return text.toLowerCase();
            case 'm':
                return text.toMixedCase();
            default:
                return text;
        }
    }

    function parseTag(text, i) {
        var resultObj,
            textStartIndex,
            resultStr = '',
            code,
            textToTransform;

        while (text[i] === '<' && text[i + 1] !== '/') {
            i += 1;
            code = text[i];
            while (text[i] !== '>') {
                i += 1;
            }
            i += 1;
            textStartIndex = i;
            while (text[i] !== '<') {
                i += 1;
            }
            // nested tag
            if (text[i + 1] !== '/') {
                if (i - textStartIndex) {
                    resultStr += transformText(text.substring(textStartIndex, i), code);
                }
                resultObj = parseTag(text, i);
                resultStr += resultObj.string;
                i = resultObj.i + 1;
                textStartIndex = i;
                while (text[i] !== '<') {
                    i += 1;
                }
            }
            if (text[i + 1] === '/') { // close tag
                textToTransform = text.substring(textStartIndex, i);
                // end tag
                resultStr += transformText(textToTransform, code);
                while (text[i] !== '>') {
                    i += 1;
                }
            }
        }

        return {
            string: resultStr,
            i: i
        };
    }

    function parseText(text) {
        var i,
            len,
            normalText = 0,
            resultStr = '',
            resultObj;

        for (i = 0, len = text.length; i < len;) {
            if (text[i] === '<' && text[i + 1] !== '/') { // tag
                if (i - normalText > 0) {
                    resultStr += text.substring(normalText, i);
                }
                resultObj = parseTag(text, i);
                resultStr += resultObj.string;
                i = resultObj.i;
                normalText = i;
            } else {
                i += 1;
            }
        }
        if (i - normalText > 0) {
            resultStr += text.substr(i);
        }
        return resultStr;
    }

    var text = '<html><head><title>Sample site</title></head> <body> <div>text<div>more text</div>and more...</div>in body</body></html>';
    console.log(parseText(text));
})();