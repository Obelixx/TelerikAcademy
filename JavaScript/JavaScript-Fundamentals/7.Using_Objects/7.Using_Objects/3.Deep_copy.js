var output = '', obj = { 0: 0, 1: [1, 2], 2: 'hi', name: 'gosho', sayName: function () { console.log(this.name) } }, objNew = {}, arr = [1, -10, null, 'Hi', function sayHi() { console.log('Hi from array!') }], arrNew = [];

output += 'Object.keys(obj) = ' + Object.keys(obj) + '<br />';
output += '&nbsp; after: deepCopy(arr, arrNew); = ' + deepCopy(obj, objNew) + '<br />';
output += 'Object.keys(objNew) = ' + Object.keys(objNew) + '<br />';
output += 'You can use console to check "obj" and result in "objNew"!!! <br /> <br />';


output += 'arr = ' + arr + '<br />';
output += '&nbsp; after: deepCopy(arr, arrNew); = ' + deepCopy(arr, arrNew) + '<br />';
output += 'arrNew = ' + arrNew + '<br />';


if (document.getElementById('Deep_copy') != null) document.getElementById('Deep_copy').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));


function deepCopy(objFrom, objTo) {
    var propName;
    if (typeof (objFrom) != typeof ({}) || typeof (objTo) != typeof ({})) {
        return false;
    }
    for (propName in objFrom) {
        if (typeof (objFrom[propName]) == typeof ({}) && objFrom[propName] !== null && objTo[propName]) {
            deepCopy(objTo[propName], objFrom[propName]);
        } else {
            objTo[propName] = objFrom[propName];
        }
    }
    return true;
}