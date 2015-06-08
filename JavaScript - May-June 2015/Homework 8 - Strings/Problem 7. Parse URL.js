/*
 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from
 it the [protocol], [server] and [resource] elements.  Return the elements in a JSON object.
*/

(function () {

    function isLetter (code) {
        if ((code > 64 && code < 91) || code > 96 && code < 123) {
            return true;
        }
        return false;
    }

    function extractURL (url) {
        var i = 0,
            results = {},
            serverStartIndex;
        while (url[i] !== ':'){
            i += 1;
        }
        results['protocol'] = url.substr(0, i);

        while (!isLetter(url.charCodeAt(i))) {
            i += 1;
        }
        serverStartIndex = i;

        while (url[i] !== '/') {
            i += 1;
        }
        results['server'] = url.substring(serverStartIndex, i);

        results['resource'] = url.substr(i);
        return results;
    }

    var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
    console.log (extractURL(url));
})();