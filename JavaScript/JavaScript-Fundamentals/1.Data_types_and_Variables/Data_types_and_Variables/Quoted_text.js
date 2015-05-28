var quotedTextV1 = "`'How you doin'?', Joey said'.",
quotedTextV2 = '`\'How you doin\'?\', Joey said\'.',
quotedTextV3 = 'Target: "C:\\Windwos\\System"';

var output = 'quotedTextV1 = ' + quotedTextV1 + '<br />'
    + 'quotedTextV2 = ' + quotedTextV2 + '<br />'
    + 'quotedTextV3 = ' + quotedTextV3 + '<br />';
document.getElementById('Quoted_text').innerHTML += output;
console.log(output.replace(/<br \/>/gi, "\n"));