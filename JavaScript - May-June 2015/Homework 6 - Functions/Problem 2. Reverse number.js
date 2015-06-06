/* Write a function that reverses the digits of given decimal number. */

function reverseNumber(number) {
    var i,
        reversed = [];

    number = number.toString();

    for (i = number.length; i >= 0; i -= 1) {
        reversed.push(number[i]);
    }
    console.log (reversed.join(''));
}

reverseNumber(123456789.66);