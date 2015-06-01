/* Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console. */

var array = new Array (20),
    len = array.length,
    i;

for (i = 0; i < len; i += 1) {
    array[i] = i * 5;
}

console.log (array);