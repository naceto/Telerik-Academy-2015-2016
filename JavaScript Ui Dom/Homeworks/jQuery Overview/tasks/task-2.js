/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
    function checkSelector(selector) {
        if (typeof selector !== 'string' && !(selector instanceof jQuery)) {
            throw new Error('invalid selector');
        }

        if (typeof selector === 'string') {
            selector = $(selector);
        }

        if (selector.length === 0) {
            throw new Error('selector does not select anything');
        }

        return selector;
    }
    return function (selector) {
        var $root,
            $buttons,
            $contents,
            $content;

        $root = checkSelector(selector);

        $buttons = $root.children().filter('.button');
        $buttons.html('hide');
        $contents = $root.children().filter('.content');
        $contents.css('display', '');


        $root.on('click', 'a.button', function () {
            var $this = $(this),
                $element;

            $element = $this.next();
            while ($element.length) {
                if ($element.hasClass('content')) {
                    $content = $element;
                    break;
                }
                $element = $element.next();
            }

            if ($content.length !== 0) {
                if ($content.css('display') !== 'none') {
                    $content.css('display', 'none');
                    $this.html('show');
                } else {
                    $content.css('display', '');
                    $this.html('hide');
                }
            }
        })

    };
};

module.exports = solve;