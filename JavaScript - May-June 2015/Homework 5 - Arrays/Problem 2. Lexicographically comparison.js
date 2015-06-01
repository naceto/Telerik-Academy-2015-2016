/* Write a script that compares two char arrays lexicographically (letter by letter). */

var array1 = ['q', 'h', 'd'],
    array2 = ['q', 'm', 'a'],
    len = Math.min (array1.length, array2.length),
    first = 0,
    i;

for (i = 0; i < len; i += 1) {
    if (array1[i] < array2[i]) {
        first = 1;
        break;
    } else if (array1[i] > array2[i]) {
        first = 2;
        break;
    }
}

if (first === 0) {
    console.log ('the arrays are lexicographically equal.');
} else {
    console.log ('the ' + (first === 1 ? 'first' : 'second') + ' array is lexicographically first.');
}