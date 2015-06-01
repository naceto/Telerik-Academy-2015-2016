/* Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm. */

var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16],
    imax = array.length,
    imin = 0,
    mid,
    searchNum = 15,
    foundI,
    currentNum;

while (imin <= imax) {
    mid = Math.round(imin + ((imax - imin) / 2));
    currentNum = array[mid];
    
    if (currentNum === searchNum) {
        foundI = mid;
        break;
    } else if (searchNum > currentNum) {
        imin = mid + 1;
    } else {
        imax = mid - 1;
    }
}

console.log (foundI);