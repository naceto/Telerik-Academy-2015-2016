/* Write an expression that checks if given positive integer number n (n ≤ 100) is prime. */
var isPrime = [];

var size = 99;
while (size--) {
    isPrime[size] = true;
}

var i;
for (i = 0; i <= 100; i+=1) {
    if (i == 1) {
            isPrime[i] = false;
            continue;
    }
    var j;
    for (j = 0; j <= 100; j+=1) {
        if (j == 1 || j == i) {
            continue;
        }
        if (i % j === 0) {
            isPrime[i] = false;
        }
    }
}

for (i = 0; i <= 100; i+=1) {
    if (isPrime[i]) {
        console.log (i);
    }
}