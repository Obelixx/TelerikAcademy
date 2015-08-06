function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this);
            var $template = $('#' + $this.attr('data-template'));
            var compiledTemplate = handlebars.compile($template.html());
            data.forEach(function (dataItem) {
                $this.append(compiledTemplate(dataItem));
            })
            return this;
        };
    };
module.exports = solve;
}
