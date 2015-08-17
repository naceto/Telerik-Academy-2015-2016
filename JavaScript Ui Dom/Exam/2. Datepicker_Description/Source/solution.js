function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

        var $this = $(this);
        var parent = $this.parent();
        var selectedDate = new Date(2015, 6, 8);

        //Elements
        var div = $('<div />');
        var table = $('<table />');
        var thead = $('<thead />');
        var tbody = $('<tbody />');
        var th = $('<th />');
        var td = $('<td />');
        var tr = $('<tr />');
        var button = $('<button />');

        var wrapper = div.clone().addClass('datepicker-wrapper');
        wrapper.append($this);

        var datepickerContainer = div.clone().addClass('datepicker-content');

        function getFirstSunday(dateObj) {
            dateObj = dateObj || new Date();
            var month = dateObj.getMonth();
            var year = dateObj.getFullYear();

            var firstDay = new Date(year, month, 1);

            while (firstDay.getDayName() !== WEEK_DAY_NAMES[0]) {
                firstDay.setDate(firstDay.getDate() - 1);
            }
            return firstDay;
        }

        function createHeader (selectedDate) {
            var headerContainer = div.clone();
            headerContainer.addClass('controls');
            var buttonPrev = button.clone().addClass('btn').addClass('prev');
            buttonPrev.html('<');
            var buttonNext = button.clone().addClass('btn').addClass('next');
            buttonNext.html('>');
            var currentMonth = div.clone().addClass('current-month');
            currentMonth.html(selectedDate.getMonthName() + " " + selectedDate.getFullYear());
            headerContainer.append(buttonPrev);
            headerContainer.append(currentMonth);
            headerContainer.append(buttonNext);
            datepickerContainer.append(headerContainer);
        }

        createHeader(selectedDate);

        function createCalendar(forDate) {
            forDate = forDate || new Date();

            var calendarTable = table.clone().addClass('calendar');
            var calendarHeader = thead.clone();
            var thcolumn;
            var i, len, j, jlen;
            for (i = 0, len = 7; i < len; i += 1) {
                thcolumn = th.clone().html(WEEK_DAY_NAMES[i]);
                calendarHeader.append(thcolumn);
            }

            calendarTable.append(calendarHeader);
            var tableBody = tbody.clone();
            calendarTable.append(tableBody);
            var startFrom = getFirstSunday(forDate);
            for (i = 0, len = 6; i < len; i += 1) {
                var tableRow = tr.clone();
                for (j = 0, jlen = 7; j < jlen; j += 1) {
                    var tableData = td.clone();
                    tableData.html(startFrom.getDate());
                    if (startFrom.getMonth() !== forDate.getMonth()) {
                        tableData.addClass('another-month');
                    } else {
                        tableData.addClass('current-month');
                    }

                    tableRow.append(tableData);
                    startFrom.setDate(startFrom.getDate() + 1);

                }
                tableBody.append(tableRow);
            }
            datepickerContainer.append(calendarTable);
        }

        createCalendar(selectedDate);

        function createFooter (selectedDate) {
            var footerContainer = div.clone().addClass('current-date');
            var today = new Date();
            var link = $('<a />').html(today.getDate() + ' ' + today.getMonthName() + ' ' + today.getFullYear());
            link.addClass('current-date-link');
            footerContainer.append(link);
            datepickerContainer.append(footerContainer);
        }
        createFooter(selectedDate);

        wrapper.append(datepickerContainer);

        wrapper.on('click', '.btn', function (ev) {
            var target = $(ev.target);

            if (target.hasClass('prev')) {
                selectedDate.setMonth(selectedDate.getMonth() - 1);
            } else if (target.hasClass('next')) {
                selectedDate.setMonth(selectedDate.getMonth() + 1);
            }

            datepickerContainer.html('');
            createHeader(selectedDate);
            createCalendar(selectedDate);
            createFooter(selectedDate);
        });

        $this.on('click', function (ev) {
            var $this = $(this);
            datepickerContainer.addClass('datepicker-content-visible');
            ev.bubbles = false;
            return false;
        });

        datepickerContainer.on('click', 'td', function (ev) {
            var target = $(ev.target);
            if(target.hasClass('current-month')) {
                var date = target.html();
                $this.val(date + '/' + (selectedDate.getMonth() + 1) + '/' + selectedDate.getFullYear());
                datepickerContainer.removeClass('datepicker-content-visible');
            }
        });

        datepickerContainer.on('click', 'a', function () {
            var today = new Date();
            $this.val(today.getDate() + '/' + (today.getMonth() + 1) + '/' + today.getFullYear());
            datepickerContainer.removeClass('datepicker-content-visible');
        });

        parent.append(wrapper);
        return this;
    };
};