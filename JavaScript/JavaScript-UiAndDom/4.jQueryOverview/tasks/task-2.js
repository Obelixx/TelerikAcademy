/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {
        if (!selector || typeof (selector) != 'string') {
            throw new error(slector + '  is bad selector')
        }
        var $selector = $(selector);
        var $buttons = $(selector + ' .button');
        if (!$selector || !$buttons) {
            throw new Error('no selector or buttons')
        } else if ($selector.length) {
            $buttons.text('hide');
            $selector.on('click', '.button', onButtonClick);
            function onButtonClick() {
                var $this = $(this);
                var $content = $this;
                do {
                    $content = $content.next();
                } while (!$content.hasClass('content'))

                if ($content.hasClass('content')) {
                    if ($content.css('display') == 'none') {
                        $content.css('display', '');
                        $this.text('hide');
                    } else {
                        $content.css('display', 'none');
                        $this.text('show');
                    }
                }
            }
        } else {
            throw new Error('selector not exist');
        }
    };
};
module.exports = solve;
