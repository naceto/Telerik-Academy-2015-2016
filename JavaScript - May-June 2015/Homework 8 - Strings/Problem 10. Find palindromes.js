/* Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe". */

(function () {
    function checkIfPalindrom (text) {
        var i,
            j;

        for (i = 0, j = text.length - 1; i < j; i += 1, j -= 1) {
            if (text[i] !== text[j]) {
                return false;
            }
        }
        return true;
    }

    function extractPalindroms (text) {
        var strArr = text.split (' '),
            i,
            len,
            result = [],
            word;

        for (i = 0, len = strArr.length; i < len; i += 1) {
            word = strArr[i];
            if (checkIfPalindrom(word)) {
                result.push (word);
            }
        }
        return result;
    }

    var text = 'aABcBAa amma LAAL fasfasdfsdf gosho petran';
    console.log (extractPalindroms(text));
})();