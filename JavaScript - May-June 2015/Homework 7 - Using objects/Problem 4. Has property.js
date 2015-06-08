/* Write a function that checks if a given object contains a given property. */

(function () {
    
    function hasProperty (obj, prop) {
        return obj[prop] !== undefined ? true : false;
    }
    
    var obj = {
            'luybcho': 3000
        }
        
    console.log(hasProperty(obj, 'luybcho'));
    console.log(hasProperty(obj, 'pesho'));
    
}) ();