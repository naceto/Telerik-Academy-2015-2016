/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed
*/

module.exports = function () {

  return function (element, contents) {
      var i,
          len,
          div,
          docFragment,
          content;

      if (typeof element === 'string') {
          element = document.getElementById(element);
      }

      if (!element) {
          throw new Error("Invalid element/element id.");
      }

      if (!contents) {
          throw new Error('contents were not provided');
      }

      docFragment  = document.createDocumentFragment();

      for (i = 0, len = contents.length; i < len; i += 1) {
          content = contents[i];
          if (typeof content !== 'string' && typeof content !== 'number') {
              console.log (content, typeof content);
              throw new Error('content number ' + i + ' is not a string or a number.');
          }

          div = document.createElement('div');
          div.innerHTML = contents[i];
          docFragment.appendChild(div);
      }

      // http://jsperf.com/innerhtml-vs-removechild
      while (element.firstChild) {
          element.removeChild(element.firstChild);
      }

      element.appendChild(docFragment);
  };
};