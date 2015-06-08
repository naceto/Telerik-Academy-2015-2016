(function () {

    /*
     Problem 1. Make person

     Write a function for creating persons.
     Each person must have firstname, lastname, age and gender (true is female, false is male)
     Generate an array with ten person with different names, ages and genders
     */
    var Person = function (firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.genger = gender;
    };

    Person.prototype.fullName = function () {
        return this.firstName + ' ' + this.lastName;
    }

    var arr = [];
    arr.push (new Person('Hosho', 'Mosho', 23, false));
    arr.push (new Person('Why', 'Not', 23, true));
    arr.push (new Person('Mosho', 'Gosho', 23, false));
    arr.push (new Person('Dead', 'pool', 43, false));
    arr.push (new Person('Black', 'Widow', 23, true));
    arr.push (new Person('Minko', 'Minkov', 32, false));
    arr.push (new Person('Regina', 'Scarface', 23, true));
    arr.push (new Person('Blq', 'Blq', 80, true));
    arr.push (new Person('Ivancho', 'Nqkoisi', 17, false));
    arr.push (new Person('Denehrys', 'Targerian', 17, true));
    console.log ('Problem 1.')
    console.log (JSON.stringify(arr));


    /* Problem 2. People of age

     Write a function that checks if an array of person contains only people of age (with age 18 or greater)
     Use only array methods and no regular loops (for, while)
    */

    function checkAge (from, to) {
        return function (item, index, arr) {
            if (item.age >= from && item.age <= to) {
                return true;
            }
            return false;
        }
    };
    console.log ('\n\nProblem 2.')
    console.log ('Are all people in the array older than 18? -> ' + arr.every(checkAge(18, 150)));

    /*
     Problem 3. Underage people

     Write a function that prints all underaged persons of an array of person
     Use Array#filter and Array#forEach
     Use only array methods and no regular loops (for, while)
    */
    var result = arr.filter(function(item, index, array) {
        if (item.age < 18) {
            return true;
        }
        return false;
    });

    console.log ('\n\nProblem 3.')
    result.forEach(function(item, index) {
        console.log (JSON.stringify(item));
    });

    /*
     Problem 4. Average age of females

     Write a function that calculates the average age of all females, extracted from an array of persons
     Use Array#filter
     Use only array methods and no regular loops (for, while)
    */
    var combinedAge = 0;
    result = arr.filter(function (person, index, array) {
        if (person.genger) {
            combinedAge += person.age;
        }
        return person.genger;
    });

    console.log ('\n\nProblem 4.');
    console.log ('The average age of all females in the array is: ' + (combinedAge / result.length));

    /*
     Problem 5. Youngest person

     Write a function that finds the youngest male person in a given array of people and prints his full name
     Use only array methods and no regular loops (for, while)
     Use Array#find
     */

    if (!Array.prototype.find) {
        Array.prototype.find = function(callback) {
            var i, len = this.length;
            for (i = 0; i < len; i+=1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        }
    }

    var tempArr = arr.slice();
    result = tempArr.sort(function (lhs, rhs) {
        return lhs.age - rhs.age;
    }).find (function (item, index, arr) {
        return item.genger;
    });

    console.log('\n\nProblem 5.');
    console.log (result.fullName());

    /*
     Problem 6. Group people

     Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
     Use Array#reduce
     Use only array methods and no regular loops (for, while)
    */

    result = arr.reduce(function (newObj, item) {
        var firstLetter = item.firstName[0];
        newObj[firstLetter] = newObj[firstLetter] || [];
        newObj[firstLetter].push(item);
        return newObj;
    }, {});
    console.log ('\n\nProblem 6.');
    console.log (result);
}) ();