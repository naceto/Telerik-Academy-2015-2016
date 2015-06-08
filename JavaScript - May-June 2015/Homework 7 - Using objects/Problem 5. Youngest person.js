/* 
    Write a function that finds the youngest person in a given array of people and prints his/hers         full name. Each person has properties firstname, lastname and age.
*/

(function () {
    'use strict';
    var Person = function (fistName, lastName, age) {
        this.firstName = fistName;
        this.lastName = lastName;
        this.age = age;
    }
    
    Person.prototype.getFullName = function () {
        return this.firstName + ' ' + this.lastName;
    }
    
    function findYoungest (array) {
        var len,
            i,
            youngest,
            current;

        for (i = 0, len = array.length; i < len; i += 1) {
            current = array[i];
            if (!youngest || youngest.age > current.age) {
                youngest = current;
            }
        }
        return youngest;
    }
    
    var arrayOfPeople = [ 
         new Person('Pesho', 'Petrov', 23),
         new Person('Minko', 'Sashev', 20),
         new Person('Georgi', 'Goshev', 23)
        ],
        youngest;
    
    youngest = findYoungest (arrayOfPeople);
    console.log(youngest.getFullName());
}) ();

