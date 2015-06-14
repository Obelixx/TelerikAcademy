var output = '';
//Works when runned in web page!
output += 'current page is: ' + window.location.pathname + '<br />' + '&nbsp; div elements count = ' + countDivs() + '<br />';

if (document.getElementById('Number_of_elements') != null) document.getElementById('Number_of_elements').innerHTML += output;
console.log(output.replace(/<br \/>/gi, '\n').replace(/&nbsp;/gi, ' '));

function countDivs() {
    
    return document.getElementsByTagName("div").length
}