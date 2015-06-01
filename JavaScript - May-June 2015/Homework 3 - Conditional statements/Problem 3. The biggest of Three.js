/*  Write a script that finds the biggest of three numbers.
    Use nested if statements. */

var a = 1,
    b = 25,
    c = -5;

var biggest = a;
biggest = b > biggest ? b : biggest;
biggest = c > biggest ? c : biggest;
console.log (biggest);
