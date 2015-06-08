/*
    Write a function that groups an array of people by age, first or last name.
    The function must return an associative array, with keys - the groups, and values - arrays with       people in this groups. Use function overloading (i.e. just one function).
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
    
    function groupBy (obj, byWhat) {
        byWhat = byWhat || 'age';
        var index,
            person,
            key,
            newArray = {};
        for (index in obj) {
            if (!obj.hasOwnProperty(index)) {
                continue;
            }

            person = obj[index];
            key = (person[byWhat]).toString();
            newArray[key] = newArray[key] || [];
            newArray[key].push(person);
        }
        return newArray;
    }
    
    var arrayOfPeople = [ 
         new Person('Pesho', 'Petrov', 23),
         new Person('Minko', 'Sashev', 20),
         new Person('Georgi', 'Goshev', 23),
         new Person('Georgi', 'BLqq', 23)
        ],
    result;
    
    // 1 argument (defaut) by age
    result = groupBy (arrayOfPeople);
    console.log (result);
    
    // second argument specifies 
    result = groupBy (arrayOfPeople, 'firstName');
    console.log (result);
}) ();