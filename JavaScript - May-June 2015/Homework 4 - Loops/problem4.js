/* Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects. */
var k;
var array = [document, window, navigator];
for (k in array) { // can also be done with (value OF array), but its not good supported yet
    var value = array[k];
    var smallest = '', largest = '';
    var prop;
    for (prop in value) {
        if (!smallest) {
            smallest = prop;
        }
        smallest = smallest > prop ? prop : smallest;

        if (!largest) {
            largest = prop;
        }
        largest = largest < prop ? prop : largest;
    }
    console.log(smallest, largest);
}