/* Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators. */

var a = -1,
    b = -2.5,
    c = 5.1;

var negatives = 0;

if (a === 0 || b === 0 || c === 0) {
    console.log (0);
} else {
    if (a < 0) {
        ++negatives;
    }
    if (b < 0) {
        ++negatives;
    }
    if (c < 0) {
        ++negatives;
    }
    console.log(!(negatives % 2) ? '+' : '-');
}