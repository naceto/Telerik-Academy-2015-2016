/*Write a function that checks if the element at given position in given array of integers is bigger than its two
 neighbours (when such exist).*/

function checkNeighbours (array, pos) {
    var len = array.length;
    if (len < 3 || pos === 0 || pos === (len - 1)) {
        return false;
    }
    if (array[pos] > array[pos - 1] && array[pos] > array[pos + 1]) {
        return true;
    }
    return false;
}

var array = [1, 5, 3, 8, 2];
var result = checkNeighbours(array, 3);
console.log (result);