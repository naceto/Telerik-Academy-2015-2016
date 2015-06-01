/*
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
*/

var a = -1,
    b = 3,
    c = 0;

var D = Math.pow(b, 2) - 4*a*c;
if (D > 0) {
    var x1 = (-b - Math.sqrt(D)) / (2 * a);
    var x2 = (-b + Math.sqrt(D)) / (2 * a);
    if (x1 === x2) {
        console.log ('x1 = x2 = ' + x1);
    } else {
        console.log ('x1 = ' + x1 + ', x2 = ' + x2);
    }
}