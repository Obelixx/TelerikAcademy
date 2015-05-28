var nullVar = null,
undefVar,
NaNVar = NaN;

var output = 'typeof(nullVar) = ' + typeof(nullVar) + '<br />'
    + 'typeof(undefVar) = ' + typeof(undefVar) + '<br />'
    + 'typeof(NaNVar) = ' + typeof(NaNVar) + '<br />';
document.getElementById('Typeof_null').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));