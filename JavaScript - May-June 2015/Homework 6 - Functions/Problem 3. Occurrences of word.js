/*
 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
*/

function wordOccurrences (text, word, caseSensitive) {
    var i = 0,
        where = 0;

    caseSensitive = caseSensitive || false;

    if (caseSensitive) {
        text = text.toLowerCase();
        word = word.toLowerCase();
    }
    while ((where = text.indexOf(word, i)) !== -1) {
        console.log ('The searchword is found at position: ' + where);
        i = where + 1;
    }
}

var text = 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Assumenda dolor ratione amet ullam quas vel nulla, laborum sint temporibus saepe eaque enim fuga nemo. Hic perspiciatis unde soluta Dolor commodi, atque ipsa odio Dolor culpa voluptatibus ex sunt optio. Quae velit minus perferendis ipsum odit possimus vel quod quidem Dolor totam, assumenda at.';
wordOccurrences(text, 'dolor', true);