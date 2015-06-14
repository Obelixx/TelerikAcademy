var output = '', arr = [1, 2, 3], obj = { name: 'ivan' };

output += 'arr = ' + arr + '<br />';
output += '&nbsp; does arr have property "length"? - ' + hasProperty(arr, 'length') + '<br />';
output += 'Object.keys(obj) = ' + Object.keys(obj) + '<br />';
output += '&nbsp; does obj have property "length"? - ' + hasProperty(obj, 'length') + '<br />';
output += '&nbsp; does obj have property "name"? - ' + hasProperty(obj, 'name') + '<br />';

if (document.getElementById('Has_property') != null) document.getElementById('Has_property').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));


function hasProperty(obj, propName) {
    var name;    
    if (obj[propName]!=undefined) {
        return true;
    }
    return false;
}