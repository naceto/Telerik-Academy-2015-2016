/* globals module */
function solve(){	
    return function(selector) {
		var $selector = $(selector),
			divDropDownList,
			selectChildren,
			div,
			dataValue,
			childDiv,
			currentDiv,
			optionsContainer,
			selectOptionText = 'Select option';

		div = $('<div />');
		// first create the <div class="dropdown-list">
		divDropDownList = div.clone().addClass('dropdown-list');

		// move the select inside
		divDropDownList.append($selector);
		$selector.css('display', 'none');

		optionsContainer = div.clone()
			.addClass('options-container')
			.css('position', 'absolute')
			.css('display', 'none');

		selectChildren = $selector.children();
		selectChildren.each(function (index, value) {
			value = $(value);
			dataValue = value.val();
			childDiv = div.clone()
				.addClass('dropdown-item')
				.attr('data-value', dataValue)
				.attr('data-index', index)
				.html(value.html());
			optionsContainer.append(childDiv);
		});

		currentDiv = div.clone()
			.addClass('current')
			.attr('data-value', '')
			.html(selectOptionText);

		divDropDownList.append(currentDiv);
		divDropDownList.append(optionsContainer);

		divDropDownList.on('click', function(ev) {
		   var target = $(ev.target);
			if (target.hasClass('current')) {
				if (optionsContainer.css('display') !== 'none') {
					optionsContainer.css('display', 'none');
				} else {
					optionsContainer.css('display', '');
					currentDiv.html(selectOptionText);
					currentDiv.attr('data-value', '');
				}
			} else if (target.hasClass('dropdown-item')) {
				currentDiv.html(target.html());
				var dataValue = target.attr('data-value');
				currentDiv.attr('data-value', dataValue);
				$selector.val(dataValue);
				optionsContainer.css('display', 'none');
			}

		});

		$('body').append(divDropDownList);
    };
};

module.exports = solve;