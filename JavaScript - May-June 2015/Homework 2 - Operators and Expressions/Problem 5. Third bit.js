/*  Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0. */
var n = 5343;
var mask = 1 << 3;

var result = (n & mask) >> 3;
console.log (result);
