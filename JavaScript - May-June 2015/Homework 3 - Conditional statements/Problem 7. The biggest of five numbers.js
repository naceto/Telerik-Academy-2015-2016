/* Write a script that finds the greatest of given 5 variables.
   Use nested if statements.
 */

var a = -2, b = -22, c = 1, d = 0,	e = 0;

var biggest = a;

biggest = b > biggest ? b : biggest;
biggest = c > biggest ? c : biggest;
biggest = d > biggest ? d : biggest;
biggest = e > biggest ? e : biggest;

console.log (biggest);