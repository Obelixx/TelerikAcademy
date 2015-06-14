var output = '', text = "We are <mixcase>living</mixcase> in a <upcase>yellow <lowcase>sub</lowcase>marine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.",
    result;

output += 'text befor = ' + safe_tags(text) + '<br />';
text = parseTags(text);
output += 'text after = ' + safe_tags(text) + '<br />';

if (document.getElementById('Parse_tags') != null) document.getElementById('Parse_tags').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function safe_tags(str) {
    return str.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
}

function parseTags(text) {

    text.match(new RegExp('<upcase>|<lowcase>|<mixcase>','gi')).forEach(function (tag) {
        text = parseCase(text, tag);
        text = parseCase(text);
    });
    return text;

    function parseCase(taxt, casetype) {
        switch (casetype) {
            case '<upcase>':
                text = parseUpcase(text)
                break;
            case '<lowcase>':
                text = parseLowcase(text)
                break;
            case '<mixcase>':
                text = parseMixcase(text)
                break;
            default:
                text = tagsToLowCase(text);
                break;
        }
        return text;
    }

    function parseUpcase(text) {
        var tagO = '<upcase>';
        var tagC = '</upcase>';
        var start = text.indexOf(tagO);
        var end = text.indexOf(tagC);
        text = text.substring(0, start) + text.substring(start + tagO.length, end).toUpperCase() + text.substring(end + tagC.length);
        return text;
    }
    function parseLowcase(text) {
        var tagO = '<lowcase>';
        var tagC = '</lowcase>';
        var start = text.indexOf(tagO);
        var end = text.indexOf(tagC);
        text = text.substring(0, start) + text.substring(start + tagO.length, end).toLowerCase() + text.substring(end + tagC.length);
        return text;
    }
    function parseMixcase(text) {
        var tagO = '<mixcase>';
        var tagC = '</mixcase>';
        var start = text.indexOf(tagO);
        var end = text.indexOf(tagC);
        var mixCase = text.substring(start + tagO.length, end)
        , len;
        for (var i = 0, len = mixCase.length - 1; i < len; i += 1) {
            var rand = Math.random();
            if (rand >= 0.5) {
                mixCase = mixCase.substring(0, i) + mixCase.substr(i, 1).toUpperCase() + mixCase.substring(i + 1);
            } else {
                mixCase = mixCase.substring(0, i) + mixCase.substr(i, 1).toLowerCase() + mixCase.substring(i + 1);
            }
        }
        text = text.substring(0, start) + mixCase + text.substring(end + tagC.length);
        return text;
    }
    function tagsToLowCase(text) {
        ['<upcase>',
        '</upcase>',
        '<lowcase>',
        '</lowcase>',
        '<mixcase>',
        '</mixcase>'].forEach(function (tag) {
            text = text.replace(new RegExp(tag, 'gi'), tag);
        });
        return text;
    }

}