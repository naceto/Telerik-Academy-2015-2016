/* Write a function that returns the last digit of given integer as an English word. */

function lastDigit (number) {
    var lastD;
    number = number.toString();

    lastD = number[number.length - 1];
    if (isNaN(lastD)) {
        console.log('Not a number');
        return;
    }
    lastD = lastD | 0;
    switch (lastD) {
        case 0:
            console.log('Zero');
            break;
        case 1:
            console.log ('One');
            break;
        case 2:
            console.log('Two');
            break;
        case 3:
            console.log('Three');
            break;
        case 4:
            console.log('Four');
            break;
        case 5:
            console.log('Five');
            break;
        case 6:
            console.log('Six');
            break;
        case 7:
            console.log('Seven');
            break;
        case 8:
            console.log('Eight');
            break;
        case 9:
            console.log('Nine');
            break;
        default:
            console.log('Not a number');
            break;
    }
}

lastDigit('4320');