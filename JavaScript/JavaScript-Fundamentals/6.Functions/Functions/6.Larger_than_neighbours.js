var output = '', array = [1, 2, 3, 2, 4], position;


for (var position = 2; position <= 5; position += 1) {
    output += 'array = ' + array + '<br />' + 'position = ' + position + '<br />' + '&nbsp; result = ' + LargerThanNeighbours(position, array) + '<br />';
}

if (document.getElementById('Larger_than_neighbours') != null) document.getElementById('Larger_than_neighbours').innerHTML += output;
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

