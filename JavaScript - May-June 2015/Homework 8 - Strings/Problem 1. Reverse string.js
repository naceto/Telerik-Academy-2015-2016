/* Write a JavaScript function that reverses a string and returns it. */
(function () {

    function reverseString(string) {
        var arr = string.split('');
        arr.reverse();
        return arr.join('');
    }

    var str = 'hello';
    var result = reverseString(str);
    console.log (result);
})();