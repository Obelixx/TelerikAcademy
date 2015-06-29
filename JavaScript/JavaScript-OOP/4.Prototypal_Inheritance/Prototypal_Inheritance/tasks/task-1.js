/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function () {
        var domElement = {
            init: function (type) {
                if (!validateDomElement(type)) { throw new Error('bad element type'); }
                var obj = Object.create(domElement);
                obj.type = type;
                obj.attributes = [];
                obj.children = [];
                obj.parent;
                return obj;
            },
            appendChild: function (child) {
                if (typeof (child) === 'string') {
                    this.children.content = child;
                }
                this.children.push(child);
                child.parent = this;
                return this;
            },
            addAttribute: function (name, value) {
                var i, length, updated = false;
                if (!validateAttribute(name)) { throw new Error('bad attribute name'); }
                for (i = 0, length = this.attributes.length; i < length; i++) {
                    if (this.attributes[i].name === name) {
                        this.attributes[i].value = value;
                        updated = true;
                        break;
                    }
                }
                if (!updated) {
                    this.attributes.push({ name: name, value: value });
                }

                this.attributes.sort(function (a, b) { return a.name > b.name; });
                return this;
            },
            removeAttribute: function (name) {
                //if (!validateAttribute(name)) { throw new Error('bad attribute name'); }
                var i, length;
                for (i = 0, length = this.attributes.length; i < length; i++) {
                    if (this.attributes[i].name === name) {
                        break;
                    }
                }
                if (this.attributes[i].name !== name) { throw new Error('no such attribute name'); }
                this.attributes.splice(i, 1);
                return this;
            },
            get innerHTML() {
                var attributesString = '', contentOfChild = '', content = '', childTextExist = false, i, length;
                for (i = 0, length = this.attributes.length; i < length; i++) {
                    attributesString += ' ' + this.attributes[i].name + '="' + this.attributes[i].value + '"';
                }

                for (i = 0, length = this.children.length; i < length; i++) {
                    if (typeof (this.children[i]) === 'string') {
                        contentOfChild += this.children[i].toString();
                        childTextExist = true;
                    } else {
                        contentOfChild += this.children[i].innerHTML;
                        childTextExist = true;
                    }
                }
                if (!childTextExist && this.content !== undefined) {
                    content = this.content;
                }
                return '<' + this.type + attributesString + '>' + contentOfChild + content + '</' + this.type + '>';

            }
        };
        return domElement;

        function validateDomElement(type) {
            if (type === undefined) { return false; }
            if (type.length === undefined) { return false; }
            if (type.length < 1) { return false; }
            else {
                return _checkIsLatinCharsOrDigitsOnlyWithOptionForDash(type, false);
            }
        }

        function validateAttribute(name) {
            if (name === undefined) { return false; }
            if (name.length === undefined) { return false; }
            if (name.length < 1) { return false; }
            else {
                return _checkIsLatinCharsOrDigitsOnlyWithOptionForDash(name, true);
            }
        }
        function _checkIsLatinCharsOrDigitsOnlyWithOptionForDash(str, checkForDash) {
            var i, length;
            for (i = 0, length = str.length; i < length; i++) {
                if (str[i] < '0' || (str[i] > '9' && str[i] < 'A') || (str[i] > 'Z' && str[i] < 'a') || str[i] > 'z') {
                    if (checkForDash) {
                        if (str[i] === '-') { continue; }
                    }
                    return false;
                }
            }
            return true;
        }

    }());
    return domElement;
}

module.exports = solve;
