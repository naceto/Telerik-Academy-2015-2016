/*
 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
*/

(function () {
    function extractEmail(text) {
        var re = /([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)/gi;
        return text.match(re);
    }

    var text = 'aaa@abv.bg bbb@gmail.bg ccc@yahoo.bg, ddd@wtf.bg'
    console.log (extractEmail(text));

})();