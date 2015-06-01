var output, docPropMin = 'z', docPropMax = 'a', winPropMin= 'z', winPropMax = 'a', navPropMin = 'z', navPropMax = 'a', propertyName;
for (propertyName in document) {
    if (docPropMin > propertyName) { docPropMin = propertyName; }
    if (docPropMax < propertyName) { docPropMax = propertyName; }
}
for (propertyName in window) {
    if (winPropMin > propertyName) { winPropMin = propertyName; }
    if (winPropMax < propertyName) { winPropMax = propertyName; }
}
for (propertyName in navigator) {
    if (navPropMin > propertyName) { navPropMin = propertyName; }
    if (navPropMax < propertyName) { navPropMax = propertyName; }
}
output = 'document Min  = ' + docPropMin + '<br />' +
    'document Max = ' + docPropMax + '<br />' +
    'window Min = ' + winPropMin + '<br />' +
    'window Max = ' + winPropMax + '<br />' +
    'navigator Min = ' + navPropMin + '<br />' +
    'navigator Max = ' + navPropMax + '<br />';
if (document.getElementById('Lexicographically_smallest') != null) document.getElementById('Lexicographically_smallest').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));