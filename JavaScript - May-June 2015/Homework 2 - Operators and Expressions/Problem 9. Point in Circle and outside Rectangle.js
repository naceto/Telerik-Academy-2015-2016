/* Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

var circleX = 1;
var circleY = 1;
var circleRadius = 3;

var rectTop = 1;
var rectLeft = -1;
var rectRight = rectLeft + 6;
var rectBottom = rectTop - 2;


var checkX = 2.5;
var checkY = 1;

var inCircle = Math.pow(checkX - circleX, 2) + Math.pow(checkY - circleY, 2) <= Math.pow(circleRadius, 2);
var outRect = (checkY < rectBottom || checkY > rectTop) || (checkX < rectLeft || checkX > rectRight);
console.log (inCircle && outRect);