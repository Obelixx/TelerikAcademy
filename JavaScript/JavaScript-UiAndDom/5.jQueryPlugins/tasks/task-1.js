function solve() {
    return function (selector) {

        var $select = $(selector);
        var $theDiv = $('<div />').addClass('dropdown-list');
        $select.after($theDiv);

        $select.css('display', 'none').appendTo($theDiv);
        var $currentDiv = $('<div />').addClass('current').text('Choose an option').attr('data-value', '');
        $currentDiv.appendTo($theDiv);
        var $optionsDiv = $('<div />').addClass('options-container').css('position', 'absolute').css('display', 'none');
        $optionsDiv.appendTo($theDiv);

        $select.find('option').each(function (i) {
            $('<div />').addClass('dropdown-item').attr('data-value', $(this).attr('value')).attr('data-index', i.toString()).text($(this).text()).appendTo($optionsDiv);
        });

        $optionsDiv.on('click', function (event) {
            var target = $(event.target);
            $currentDiv.text(target.text());
            $currentDiv.attr('data-value', target.attr('data-value'));
            $optionsDiv.css('display', 'none');
            $select.val(target.attr('data-value')).attr('selected', 'selected');
        });

        $currentDiv.on('click', function () {
            $optionsDiv.css('display', '');
        });
    };
module.exports = solve;
}
