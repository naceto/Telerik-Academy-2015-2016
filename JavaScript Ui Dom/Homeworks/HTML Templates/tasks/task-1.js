/* globals $, module */

function solve() {
    return function (selector) {
        var template = ' <table class="items-table">' +
            '<thead>' +
            '<tr>' +
            '<th>#</th>' +
            '{{#headers}}' +
            '<th>{{this}}</th>' +
            '{{/headers}}' +
            '</tr>' +
            '</thead>' +
            '<tbody>' +
            '{{#each items}}' +
            '<tr>' +
            '<td>{{@index}}</td>' +
            '{{#each this}}' +
            '<td>{{this}}</td>' +
            '{{/each}}' +
            '</tr>' +
            '{{/each}}' +
            '</tbody>' +
            '</table>';

        $(selector).html(template);
    };
}

module.exports = solve;