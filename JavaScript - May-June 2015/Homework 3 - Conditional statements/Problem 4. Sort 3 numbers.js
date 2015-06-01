/* Sort 3 real values in descending order.
   Use nested if statements.
   Note: Don’t use arrays and the built-in sorting functionality.
*/

var a = 10,
    b = 20,
    c = 30;

var resultStr = "";

if (a >= b) {
    resultStr += a + ' ';

    if (b >= c) {
        resultStr += b + ' ' + c;
    } else {
        if ( c >= a) {
            resultStr = c + ' ' + resultStr + b;
        } else {
            resultStr += c + ' ' + b;
        }
    }
} else {
    resultStr = b + ' ';

    if (a >= c) {
        resultStr += a + ' ' + c;
    } else {
        if (c >= b) {
            resultStr = c + ' ' + resultStr + a;
        } else {
            resultStr += c + ' ' + a;
        }
    }
}

console.log (resultStr);