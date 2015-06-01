/* Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation. */

var number = 711;
var numberAsStr = "";
var hundreds = (number / 100) | 0;
var tens = number % 100;

if (hundreds) {

    switch (hundreds) {
        case 1:
            numberAsStr = 'One';
            break;
        case 2:
            numberAsStr = 'Two';
            break;
        case 3:
            numberAsStr = 'Three';
            break;
        case 4:
            numberAsStr = 'Four';
            break;
        case 5:
            numberAsStr = 'Five';
            break;
        case 6:
            numberAsStr = 'Six';
            break;
        case 7:
            numberAsStr = 'Seven';
            break;
        case 8:
            numberAsStr = 'Eight';
            break;
        case 9:
            numberAsStr = 'Nine';
            break;
    }

    if (numberAsStr) {
        numberAsStr += ' hundred';
    }

    if (tens > 0) {
        numberAsStr += ' and ';
    }
}

var ones = tens % 10;
var tensCached = tens;
tens /= 10;
tens |= 0;

if (tens === 1) {
    switch (tensCached) {
        case 11:
            numberAsStr += 'eleven';
            break;
        case 12:
            numberAsStr += 'twelve';
            break;
        case 13:
            numberAsStr += 'thirteen';
            break;
        case 14:
            numberAsStr += 'fourteen';
            break;
        case 15:
            numberAsStr += 'fifteen';
            break;
        case 16:
            numberAsStr += 'sixteen';
            break;
        case 17:
            numberAsStr += 'seventeen';
            break;
        case 18:
            numberAsStr += 'eighteen';
            break;
        case 19:
            numberAsStr += 'nineteen';
            break;
    }
} else {
    switch (tens) {
        case 2:
            numberAsStr += 'twenty ';
            break;
        case 3:
            numberAsStr += 'thirty ';
            break;
        case 4:
            numberAsStr += 'forty ';
            break;
        case 5:
            numberAsStr += 'fifty ';
            break;
        case 6:
            numberAsStr += 'sixty ';
            break;
        case 7:
            numberAsStr += 'seventy ';
            break;
        case 8:
            numberAsStr += 'eighty  ';
            break;
        case 9:
            numberAsStr += 'ninety ';
            break;
    }

    switch (ones) {
        case 1:
            numberAsStr += 'one';
            break;
        case 2:
            numberAsStr += 'two';
            break;
        case 3:
            numberAsStr += 'three';
            break;
        case 4:
            numberAsStr += 'four';
            break;
        case 5:
            numberAsStr += 'five';
            break;
        case 6:
            numberAsStr += 'six';
            break;
        case 7:
            numberAsStr += 'seven';
            break;
        case 8:
            numberAsStr += 'eight';
            break;
        case 9:
            numberAsStr += 'nine';
            break;
    }
}

console.log (numberAsStr);

