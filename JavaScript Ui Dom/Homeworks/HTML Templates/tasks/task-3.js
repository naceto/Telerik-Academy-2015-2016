function solve(){
    return function(){
        $.fn.listview = function(data){
            var $this = $(this);
            var templateId = $this.attr('data-template'),
                templateHTML = $('#' + templateId).html(),
                compiledTemplate = handlebars.compile(templateHTML);

            data.forEach(function (element) {
                $this.append(compiledTemplate(element));
            });

            return $this;
        };
    };
};

module.exports = solve;