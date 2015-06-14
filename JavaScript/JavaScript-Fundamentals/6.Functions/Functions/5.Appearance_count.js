
testCounting();

function testCounting() {
    var output = '', array, number;

    array = [1, 1, 1, 1, 2, 2, 2, 3, 3, 4], number = 2;
    output += 'array = ' + array + '<br />' + 'number = ' + number + '<br />' + '&nbsp; result = ' + countNumberInArray(number, array) + '<br />';
    array = [1, 1, 1, 1, '2', '2', 2, 22], number = 2;
    output += 'array = ' + array + '<br />' + 'number = ' + number + '<br />' + '&nbsp; result = ' + countNumberInArray(number, array) + '<br />';
    array = [], number = 2;
    output += 'array = ' + array + '<br />' + 'number = ' + number + '<br />' + '&nbsp; result = ' + countNumberInArray(number, array) + '<br />';
    array = [-2], number = 2;
    output += 'array = ' + array + '<br />' + 'number = ' + number + '<br />' + '&nbsp; result = ' + countNumberInArray(number, array) + '<br />';

    if (document.getElementById('Appearance_count') != null) document.getElementById('Appearance_count').innerHTML += output;
    console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));
}

function countNumberInArray(number, array) {
    if (arguments.length != 2) { return "Wrong parameters count!"; }
    var count = 0;
    array.forEach(function (element) {
        if (element == number) count += 1;
    })
    return count;
}

