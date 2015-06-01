/* Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius */

var circleX = 0;
var circleY = 0;
var circleRadius = 5;


var checkX = -5;
var checkY = 0;

console.log (Math.pow(checkX - circleX, 2) + Math.pow(checkY - circleY, 2) <= Math.pow(circleRadius, 2));