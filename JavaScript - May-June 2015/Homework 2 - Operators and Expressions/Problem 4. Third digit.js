/* Write an expression that checks for given integer if its third digit (right-to-left) is 7. */
var numberToCheck = 9999799;
var numberAsString = numberToCheck.toString();
if (numberAsString.length >= 3) {
    console.log (numberAsString[numberAsString.length - 3] == 7);
} else {
    console.log(false);
}