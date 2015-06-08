/*
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
*/

(function () {
    function deepCopy (object) {
        var newObject,
            index;
        
        if (object === null) {
            return null;
        }
        if (object === undefined) {
            return;
        }
        if (!isNaN(object)){
            return new Number(object);
        }
        if (Array.isArray(object)) {
            newObject = [];
        } else if (typeof object === 'object') {
            newObject = {};   
        } else {
            return object;
        }
        
        for(index in object) {
            if (!object.hasOwnProperty(index)){
                continue;
            }
            
            if (typeof object[index] === 'object') {
                newObject[index] = deepCopy(object[index]);
                continue;
            }
            newObject[index] = object[index];
        }
        return newObject;
    }
    
    
    var obj = {
        a: 1,
        b: 2,
        c: 3,
        d: {
            a: 4,
            b: 5,
            c: 6
        }
    },
    copyObj;
    
    copyObj = deepCopy(obj);
    
    copyObj.a = 8;  
    copyObj.d.a = 8;
    console.log (obj, copyObj);
    
    
    var number = new Number(5);
    var newnumber = deepCopy(number);
    console.log(number, newnumber);
}) ();