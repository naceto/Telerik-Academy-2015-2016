/*
 Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 */

// <strong>-{name}-</strong> <span>-{age}-</span>
function onLoad() {
    function generateList(people, tmpl) {
        var i,
            len,
            person,
            line,
            lines = [];

        for (i = 0, len = people.length; i < len; i += 1) {
            person = people[i];
            line = tmpl.replace('-{name}-', person.name);
            line = line.replace('-{age}-', person.age);
            lines.push(line);
        }
        return lines.join('</li><li>');
    }

    var element = document.getElementById('list');
    var people = [{name: 'Peter', age: 14}, {name: 'George', age: 55}];
    if (element) {
        var tmpl = element.innerHTML;
        element.innerHTML = '';
        tmpl = tmpl.trim();
        var peopleList = generateList(people, tmpl);
        console.log(peopleList);
        var htmlText = "<ul><li>";
        htmlText += peopleList;
        htmlText += "</li></ul>";
        element.innerHTML += htmlText;
    } else {
        console.log('wtf');
    }
}

window.addEventListener('load', onLoad);