var output = '', text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

output += 'text befor = ' + safe_tags(text) + '<br />';
output += 'text after = ' + get_text(text) + '<br />';


if (document.getElementById('Extract_text') != null) document.getElementById('Extract_text').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function get_text(str) {
    return str.replace(/<[^>]*>/g, '');
}

function safe_tags(str) {
    return str.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
}