var output = '', text = 'asdasd Pool Internet Pool DHCP dns', word = 'pool';


output += 'text = ' + text + '<br />' + 'word = ' + word + '<br />' + 'call = ' + 'ocurrencesOfWordInText(word, text)' + '<br />' + '&nbsp; reuslt = ' + ocurrencesOfWordInText(word, text) + '<br />';
output += 'text = ' + text + '<br />' + 'word = ' + word + '<br />' + 'call = ' + 'ocurrencesOfWordInText(word, text, true)' + '<br />' + '&nbsp; reuslt = ' + ocurrencesOfWordInText(word, text, true) + '<br />';

if (document.getElementById('Occurrences_of_word') != null) document.getElementById('Occurrences_of_word').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function ocurrencesOfWordInText(word, text, isItCaseSensitive) {
    var regex;
    switch (arguments.length) {
        case 2:
            isItCaseSensitive = false;
        case 3:
            if (isItCaseSensitive) { regex = new RegExp('\\b' + word + '\\b', 'g'); }
            else { regex = new RegExp('\\b' + word + '\\b', 'gi'); }
            return (text.match(regex) || []).length;
            break;
        default:
            return 'invalid arguments'
    }
}