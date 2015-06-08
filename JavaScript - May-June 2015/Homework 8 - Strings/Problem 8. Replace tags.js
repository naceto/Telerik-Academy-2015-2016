/* Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with
corresponding tags [URL=…]…/URL]. */

(function () {
    // saw it on stackoverflow and had to try this split and join method :D, don't use it during the exam thought
    function replace(text) {
        var text = text.split('<a href="').join('[URL=');
        text = text.split('">').join(']');
        text = text.split('</a>').join('[/URL]');
        return text;
    }

    var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    console.log (replace(text));
})();