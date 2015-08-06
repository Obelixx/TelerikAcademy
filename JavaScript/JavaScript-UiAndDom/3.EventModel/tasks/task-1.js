/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  If an id is provided, select the element
  Finds all elements with class button or content within the provided element
    Change the content of all .button elements with "hide"
  When a .button is clicked:
    Find the topmost .content element, that is before another .button and:
        If the .content is visible:
            Hide the .content
            Change the content of the .button to "show"
        If the .content is hidden:
            Show the .content
            Change the content of the .button to "hide"
        If there isn't a .content element after the clicked .button and before other .button, do nothing
  Throws if:
    The provided DOM element is non-existant
    The id is either not a string or does not select any DOM element


*/

function solve() {
    return function (selector) {
        var element;
        if (document.getElementById(selector)) {
            element = document.getElementById(selector);
        } else if (selector.id) {
            element = document.getElementById(selector.id);
        } else {
            throw new Error('"selector" is not a valid id or element')
        }
        var buttonElements = element.getElementsByClassName('button');
        var contentElements = element.getElementsByClassName('content');
        var i, len = buttonElements.length, button;
        for (i = 0 ; i < len; i++) {
            button = buttonElements.item(i);
            button.textContent = 'hide';
        }
        element.addEventListener('click', function (ev) {
            update(ev.target);
        }, false);

        function update(el) {
            var contentElement = el;
            do {
                contentElement = contentElement.nextElementSibling;
            } while (contentElement !== null && (contentElement.getAttribute('class') === null || contentElement.getAttribute('class').indexOf('content') === -1));
            if (contentElement !== null) {
                if (contentElement.style.display === 'none') {
                    contentElement.style.display = ''; // hide
                    el.textContent = 'hide'
                } else {
                    contentElement.style.display = 'none'; // show
                    el.textContent = 'show';
                }
            }
        };
    };
};
module.exports = solve;
