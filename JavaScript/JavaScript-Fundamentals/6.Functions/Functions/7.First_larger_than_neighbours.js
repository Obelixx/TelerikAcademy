var output = '', array = [1, 3, 3, 2, 4];

output += 'array = ' + array + '<br />' + '&nbsp; result = ' + FirstLargerThanNeighbours(array) + '<br />';

if (document.getElementById('First_larger_than_neighbours') != null) document.getElementById('First_larger_than_neighbours').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function LargerThanNeighbours(pos, array) {
    if (arguments.length != 2) { return "Wrong parameters count!"; }
    if (pos >= array.length || pos < 0) { return "Wrong postion in array!"; }
    if (array[pos - 1] != undefined) {
        if (array[pos - 1] >= array[pos]) { return false; }
    }
    if (array[pos + 1] != undefined) {
        if (array[pos + 1] >= array[pos]) { return false; }
    }
    return true;
}

function FirstLargerThanNeighbours(array) {
    var len, i;
    for (i = 0, len = array.length; i < len; i += 1) {
        if (LargerThanNeighbours(i, array)) {
            return i;
        }
    }
    return -1;
}