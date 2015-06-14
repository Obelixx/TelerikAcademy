var output = '', arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'], element = 1;

Array.prototype.remove = function (value) {    
    var i, length, arr = this;
    if (arguments.length != 1) return "bad values - use one value!";
    for (i = 0, length = arr.length; i < length; i += 1) {
        if (arr[i] === value) {
            arr.splice(i, 1);
        }
    }
    return arr;
}

output += 'arr = ' + arr + '<br />'+"here last element is the string: '1'" + '<br />'
output += '&nbsp; after: arr.remove(' + element + ') = ' + arr.remove(element) + '<br />';
output += 'arr = ' + arr + '<br />'
element = '1';
output += '&nbsp; after: arr.remove(\''+ + element + '\') = ' + arr.remove(element) + '<br />';
output += 'arr = ' + arr + '<br />'

if (document.getElementById('Remove_elements') != null) document.getElementById('Remove_elements').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

//removeing bad things!!
delete (Array.prototype.remove);


