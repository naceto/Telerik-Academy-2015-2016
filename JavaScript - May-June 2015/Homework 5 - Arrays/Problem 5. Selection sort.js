/* 
    Sorting an array means to arrange its elements in increasing order.
    Write a script to sort an array.
    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the           smallest from the rest, move it at the second position, etc.
    Hint: Use a second array
*/

var arrayToSort = [3, 2, 3, 4, 1, 2, 4],
    sortedArray = [],
    len = arrayToSort.length,
    smallest,
    smallestPos,
    i,
    j;

for (i = 0; i < len; i += 1) {
    for (j = 0; j < len; j += 1) {
        if (arrayToSort[j] == null) {
            continue;
        }

        if (!smallest || smallest > arrayToSort[j]) {
            smallest = arrayToSort[j];
            smallestPos = j;
        }
    }
    arrayToSort[smallestPos] = null;
    sortedArray[i] = smallest;
    smallest = 0;
}

console.log(sortedArray);