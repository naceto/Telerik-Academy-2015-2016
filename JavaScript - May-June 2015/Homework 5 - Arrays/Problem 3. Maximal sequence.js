/* rite a script that finds the maximal sequence of equal elements in an array. */

var array = [2, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    tmpBestStart = 0,
    tmpBestCount = 0,
    bestStart = 0,
    bestCount = 0,
    len = array.length,
    i,
    result;

for (i = 1; i < len; i += 1) {
    if (array[i - 1] === array[i]) {
        if (!tmpBestCount) {
            tmpBestCount = 1;
            tmpBestStart = i - 1;
        }
        tmpBestCount += 1;
    } else {
        tmpBestCount = 0;
    }
    if (tmpBestCount > bestCount) {
        bestCount = tmpBestCount;
        bestStart = tmpBestStart;
    }
}

result = '';
for (i = bestStart; i < bestCount + bestStart; i +=1) {
    result += array[i] + ' ';
}
console.log (result);