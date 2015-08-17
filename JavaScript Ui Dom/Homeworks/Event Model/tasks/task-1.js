/* globals $ */

/* 

 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
    Change the content of all .button elements with "hide"
 When a .button is clicked:
     Find the topmost .content element, that is before another .button and:
         If the .content is visible:
             Hide the .content
             Change the content of the .button to "show"
         If the .content is hidden:
             Show the .content
             Change the content of the .button to "hide"
         If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
     The provided DOM element is non-existant
     The id is either not a string or does not select any DOM element
*/

function solve(){
  return function (selector) {
      var selectedElement = selector,
          buttons,
          button,
          i,
          len,
          root;

      if (typeof selector === 'string') {
          selectedElement = document.getElementById(selector);
      }

      if(!selectedElement) {
          throw new Error('selector element is null1');
      }

      buttons = selectedElement.getElementsByClassName('button');

      for (i = 0, len = buttons.length; i < len; i += 1) {
          button = buttons[i];
          button.innerHTML = 'hide';
      }

      root = document.getElementById('root');
      root.addEventListener('click', buttonOnClick, false);

      function buttonOnClick(ev) {
          if (ev.target.className === 'button') {
              var target = ev.target;
              var next = target;

              while(next)	 {
                  if (next.className.indexOf('content') >= 0) {
                      break;
                  }
                  next = next.nextElementSibling;
              }

              if (next.style.display === '') {
                  target.innerHTML = 'show';
                  next.style.display = 'none';
              } else if (next.style.display === 'none') {
                  target.innerHTML = 'hide';
                  next.style.display = '';
              }
          }
      }
  }
}

module.exports = solve;