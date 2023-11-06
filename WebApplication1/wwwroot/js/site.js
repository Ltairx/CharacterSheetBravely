// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// divide words
var selectElement = document.getElementById("TextDivide");
var options = selectElement.getElementsByTagName('option');
var regex = /([a-z])([A-Z])/g;

for (var i = 0; i < options.length; i++) {
    var text = options[i].textContent;

    var formattedText = text.replace(regex, '$1 $2');

    options[i].textContent = formattedText;
}


// change font size button

document.getElementById("changeFontSizeButtonUp").addEventListener("click", function () {
    var inputElement = document.querySelector(".size-change");
    var currentFontSize = parseInt(window.getComputedStyle(inputElement).fontSize);
    var newFontSize = currentFontSize + 5;
    inputElement.style.fontSize = newFontSize + "px";
});

document.getElementById("changeFontSizeButtonDown").addEventListener("click", function () {
    var inputElement = document.querySelector(".size-change");
    var currentFontSize = parseInt(window.getComputedStyle(inputElement).fontSize);
    var newFontSize = currentFontSize - 5;
    inputElement.style.fontSize = newFontSize + "px";
});