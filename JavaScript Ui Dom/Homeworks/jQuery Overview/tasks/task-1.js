/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, []
*/

function solve() {
    function checkCount(count){
        var countAsNumber;
        if (!count) {
            throw new Error('count is missing');
        }

        countAsNumber = Number(count);
        if (count === '' || isNaN(countAsNumber)) {
            throw new Error('count cannot be converted to number');
        }

        if (countAsNumber < 1) {
            throw new Error('count cannot be less than 0');
        }

        return countAsNumber;
    }
    function checkSelector(selector) {
        if (!selector) {
            throw new Error('selector is undefined or null');
        }

        if (typeof selector !== 'string') {
            throw new Error('selector should be a string');
        }
    }

    return function (selector, count) {
        var $parent,
            i,
            $ul,
            $li,
            $clonedLi;

        checkSelector(selector);
        count = checkCount(count);
        $parent =  $(selector)
        $ul = $('<ul />').addClass('items-list');
        $li = $('<li/>').addClass('list-item');

        for (i = 0; i < count; i += 1) {
            $clonedLi = $li.clone().html('List item #' + i);
            $ul.append($clonedLi);
        }
        $parent.append($ul);
    };
};

module.exports = solve;