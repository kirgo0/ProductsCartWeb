
function getWidthOfInput(inputEl) {
    var tmp = document.createElement("span");
    tmp.className = "input-element tmp-element";
    tmp.innerHTML = inputEl.value.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
    document.body.appendChild(tmp);
    var theWidth = tmp.getBoundingClientRect().width;
    document.body.removeChild(tmp);
    return theWidth;
}

function adjustWidthOfInput(inputEl) {
    if (inputEl === null) return;
    inputEl.style.width = getWidthOfInput(inputEl) + "px";
}

function changeInputFocus(inputEl, isFocused) {
    if (inputEl === null) return;
    if (isFocused) {
        inputEl.blur();
    } else {
        inputEl.focus();
    }
}