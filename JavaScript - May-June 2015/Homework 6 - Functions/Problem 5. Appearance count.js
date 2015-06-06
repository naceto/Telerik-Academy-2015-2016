/*
 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
*/

function checkOccurrences (array, number) {
    var i = 0,
        where,
        count = 0;

    while ((where = array.indexOf(number, i)) !== -1) {
        i = where + 1;
        count += 1;
    }
    return count;
}
function checkIfItsWorkingCorrectly() {
    var arr = [5, 5, 4, 5, 1, 23, 4, 5];
    var result = checkOccurrences(arr, 5);
    console.log('Is the function working correctly? -> ' + (result === 4));
}

checkIfItsWorkingCorrectly();