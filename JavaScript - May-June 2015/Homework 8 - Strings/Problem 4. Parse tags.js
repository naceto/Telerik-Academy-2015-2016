/* You are given a text. Write a function that changes the text in all regions: */

(function () {
   String.prototype.toMixedCase = function () {
        var split = this.split(''),
            len = split.length,
            i,
            rand;

        for (i = 0; i < len; i += 1) {
            rand = Math.random();
            if (rand > 0.5) {
                split[i] = split[i].toLowerCase();
            } else {
                split[i] = split[i].toUpperCase();
            }
        }
        return split.join('');
    };

    function transformText (text, how) {
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

    function parseTag (text, i) {
        var resultObj,
            textStartIndex,
            resultStr = '',
            code,
            textToTransform;
        i += 1;
        code = text[i];
        if (code === 'u' || code === 'l' || code === 'm') {
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
                if (i - textStartIndex > 0) {
                    resultStr += transformText(text.substring(textStartIndex, i), code);
                }

                while (text[i] !== '>') {
                    i += 1;
                }
            } else { // close tag
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

    function parseText (text) {
        var i,
            len,
            normalText = 0,
            resultStr = '',
            resultObj;

        for (i = 0, len = text.length; i < len; i += 1) {
            if (text[i] === '<' && text[i + 1] !== '/') { // tag
                if (i - normalText > 0) {
                    resultStr += text.substring(normalText, i);
                }
                resultObj = parseTag(text, i);
                resultStr += resultObj.string;
                i = resultObj.i;
                normalText = i + 1;
            }
        }
        if (i - normalText > 0) {
            resultStr += text.substr(normalText);
        }
        return resultStr;
    }

    var text = "<mixcase>We <upcase>a<lowcase>r</lowcase>e</upcase> living</mixcase> in a <upcase>yellow <mixcase>submarine</mixcase></upcase>. We <mixcase>don't <lowcase>have</lowcase></mixcase> <lowcase>anything</lowcase> <mixcase>else</mixcase>.";
    var result = parseText (text);
    console.log (result);
})();