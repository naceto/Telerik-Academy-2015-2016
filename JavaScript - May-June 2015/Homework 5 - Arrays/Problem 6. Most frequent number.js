/* Write a script that finds the most frequent number in an array. */
var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    resultArray = [],
    len = array.length,
    i,
    largestIndex,
    biggest;

for (i = 0; i < len; i += 1) {
    resultArray[array[i]] = resultArray[array[i]] || 0;
    ++resultArray[array[i]];
}

len = resultArray.length;
largestIndex = 0;

for (i = 0; i < len; i += 1) {
    if (!biggest || biggest < resultArray[i]) {
        largestIndex = i;
        biggest = resultArray[i];
    }
}

console.log (largestIndex + '(' + resultArray[largestIndex] + ' times)');