/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/
function solve() {
    return function (element, contents) {
        var domElement;
        if (document.getElementById(element)) {
            domElement = document.getElementById(element)
        } else if (element.id) {
            domElement = document.getElementById(element.id)
        } else {
            throw new Error('parameter is neither string or existing DOM element');
        }
        if (!contents) {
            throw new Error('contents is missing');
        }
        var fragment = document.createDocumentFragment();
        contents.forEach(function (contentsElement) {
            if (!(typeof (contentsElement) === 'string' || typeof (contentsElement) === 'number')) {
                throw new Error('"' + contentsElement + '"' + ' is not string or number');
            }
            var newDiv = document.createElement("div");
            newDiv.innerHTML = contentsElement;
            fragment.appendChild(newDiv);
        })
        domElement.innerHTML = '';
        domElement.appendChild(fragment);
    };
    module.exports = solve;
};
