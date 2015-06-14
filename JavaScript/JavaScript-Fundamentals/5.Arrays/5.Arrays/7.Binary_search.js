var output, result, last, position,
    sequence = [1, 2, 6, 7, 8, 12, 34, 55, 69], //sorted sequence!
    searchFor = 6;
position = BinarySearch(sequence, searchFor);
result = position;
output = 'sequence = ' + sequence + '<br />' + 'searchFor = ' + searchFor + '<br />' + 'result = ' + result.toString();
if (document.getElementById('Binary_search') != null) document.getElementById('Binary_search').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n'));

//from my C# homework with edits for JavaScript..
function BinarySearch(array_of_ints, element) {
    var index = parseInt(array_of_ints.length / 2),
        begin = 0,
        end = array_of_ints.length - 1,
        position = -1;

    while (index != 0 || index != array_of_ints.length - 1) {
        if (array_of_ints[index] == element) {
            position = index;
            break;
        }
        if (element < array_of_ints[index]) {

            end -= parseInt((end - begin) / 2);
            if (parseInt((end - begin) / 2) == 0)
                index--;
            else
                index -= parseInt((end - begin) / 2);
        }
        else {
            begin += parseInt((end - begin) / 2);
            index += parseInt((end - begin) / 2);
        }
        if (parseInt((end - begin) / 2) == 0 && begin != 0) break;
    }
    return (position);
}