function solve() {
    return function (selector, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;

        if (typeof selector !== 'string') {
            throw new Error('selector must be a string');
        }
        selector = document.querySelector(selector);

        //ELEMENTS
        var div = document.createElement('div');
        var input = document.createElement('input');
        var button = document.createElement('button');
        var label = document.createElement('label');

        var mainContainer = div.cloneNode(true);
        mainContainer.className = 'items-control';

        // ADD ELEMENTS
        var addControlsContainer = div.cloneNode(true);
        addControlsContainer.className = 'add-controls';
        var addLabel = label.cloneNode(true);
        addLabel.innerHTML = 'Enter text';
        addControlsContainer.appendChild(addLabel);

        var addInput = input.cloneNode(true);
        addInput.type = 'text';
        addInput.name = 'addEntry';
        addControlsContainer.appendChild(addInput);

        var addButton = button.cloneNode(true);
        addButton.className = 'button';
        addButton.innerHTML = 'Add';
        addControlsContainer.appendChild(addButton);
        mainContainer.appendChild(addControlsContainer);


        //SEARCH CONTROLS
        var searchElementsContainer = div.cloneNode(true);
        searchElementsContainer.className = 'search-controls';
        var searchLabel = label.cloneNode(true);
        searchLabel.innerHTML = 'Search';
        searchElementsContainer.appendChild(searchLabel);
        var searchInput = input.cloneNode(true);
        searchInput.type = 'text';
        searchInput.name = 'search';
        searchElementsContainer.appendChild(searchInput);
        mainContainer.appendChild(searchElementsContainer);


        //RESULT CONTROLS
        var resultControlsContainer = div.cloneNode(true);
        resultControlsContainer.className = 'result-controls';
        var itemsList = div.cloneNode(true);
        itemsList.className = 'items-list';
        resultControlsContainer.appendChild(itemsList);
        mainContainer.appendChild(resultControlsContainer);

        mainContainer.addEventListener('click', function (ev) {
            var target = ev.target;
            if (target.className.indexOf('button') !== -1 &&
                    target.parentElement.className.indexOf('add-controls') !== -1) {
                var input = target.previousElementSibling;
                var value = input.value;
                if (value.length > 0) {
                    addListItem(value);
                }
                return;
            }

            if (target.className.indexOf('button') !== -1 &&
                    target.parentElement.className.indexOf('list-item') !== -1) {
                //WTFF, it works soo, ammm, i'll leave it here
                target.parentElement.parentElement.removeChild(target.parentElement);
                return;
            }
        }, false);

        function addListItem(text) {
            var listItem = div.cloneNode(true);
            listItem.className = 'list-item';

            var deleteButton = button.cloneNode(true);
            deleteButton.className = 'button';
            deleteButton.innerHTML = 'X';

            listItem.appendChild(deleteButton);
            listItem.innerHTML += text;

            itemsList.appendChild(listItem);
        }


        //SEARCH EVENT
        searchInput.addEventListener('change', function (ev) {
            var target = ev.target;
            filterListElements(target.value);
        }, false);

        function filterListElements (filter) {
            var elements = itemsList.childNodes;
            var i, len = elements.length;
            var element;
            var text;

            if (!isCaseSensitive) {
                filter = filter.toLowerCase();
            }

            for (i = 0; i < len; i += 1) {
                element = elements[i];
                text = element.lastChild.data;

                if (!isCaseSensitive) {
                    text = text.toLowerCase();
                }

                if (text.indexOf(filter) === -1) {
                    element.style.display = 'none';
                } else {
                    element.style.display = '';
                }
            }
        }

        selector.appendChild(mainContainer);
    };
}

module.exports = solve;