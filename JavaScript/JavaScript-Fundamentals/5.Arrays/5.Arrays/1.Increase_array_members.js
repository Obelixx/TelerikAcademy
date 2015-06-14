var len,output,arr = Array(20);
for (var i = 0, len = arr.length; i < len; i += 1) {
    arr[i] = i * 5;
}
output = arr.toString();
if (document.getElementById('Increase_array_members') != null) document.getElementById('Increase_array_members').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));