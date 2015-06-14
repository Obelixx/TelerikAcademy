var len, output, result,
    firstCharArr = 'aaac'.split(''),
    secondCharArr = 'aaab'.split('');
for (var i = 0, len = Math.max(firstCharArr.length, secondCharArr.length) ; i < len; i += 1) {
    if (firstCharArr[i] < secondCharArr[i]) {
        result = firstCharArr
        break;
    } if (secondCharArr[i] < firstCharArr[i]) {
        result = secondCharArr;
        break;
    } if (firstCharArr[i] === undefined) {
        result = firstCharArr;
        break;
    } if (secondCharArr[i] === undefined) {
        result = secondCharArr;
        break;
    }
}
if (result === firstCharArr) {
    result = 'First: ' + firstCharArr + '; Second: ' + secondCharArr + ';';
} else if (result === secondCharArr) {
    result = 'First: ' + secondCharArr + '; Second: ' + firstCharArr + ';';
} else result = 'Arrays are the same.';

output = 'firstCharArr = ' + firstCharArr + '<br />' + 'secondCharArr = ' + secondCharArr + '<br />' + result;
if (document.getElementById('Lexicographically_comparison') != null) document.getElementById('Lexicographically_comparison').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));