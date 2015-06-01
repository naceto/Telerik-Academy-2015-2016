/* Write a script that finds the max and min number from a sequence of numbers. */

var max, min, i, n = 50;
for (i = 0; i <= n; i += 1) {
    if (!min) {
        min = i;
    }
    if (!max) {
        max = i;
    }
    max = max > i ? max : i;
    min = min < i ? min : i;
}

console.log ('min: ' + min, 'max: ' + max);