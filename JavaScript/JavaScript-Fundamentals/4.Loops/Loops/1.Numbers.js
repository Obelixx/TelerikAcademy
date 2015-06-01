var len, output, result = [],
	n = 10;
for (i = 1, len = n ; i <= len ; i++) { result.push(i); }
output = 'n = '+ n + '<br />' + result.join(', ')
if (document.getElementById('Numbers') != null) document.getElementById('Numbers').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));