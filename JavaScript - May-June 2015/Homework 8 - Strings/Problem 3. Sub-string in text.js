/* Write a JavaScript function that finds how many times a substring is contained in a given text (perform case
insensitive search). */

(function () {
    function countContained (text, searchWord) {
        var i = 0,
            count = 0;

        while ((i = text.indexOf(searchWord, i)) !== -1) {
            count += 1;
            i += 1;
        }
        return count;
    }

    var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight." +
        " So we are drinking all the day. We will move out of it in 5 days.";
    console.log (countContained(text, 'in'));
})();