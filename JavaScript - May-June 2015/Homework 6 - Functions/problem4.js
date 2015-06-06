/* Write a function to count the number of div elements on the web page */

function countDivs () {
    var divs = document.getElementsByTagName('div');
    console.log ('Number of <div> elements on the page is: ' + divs.length);
}
window.addEventListener('load', countDivs)