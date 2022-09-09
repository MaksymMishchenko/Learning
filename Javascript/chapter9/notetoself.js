window.onload = init;

function init() {
    var button = document.getElementById("add_button");
    button.onclick = createSticky;
    var stickiesArray = getStickiesArray();
    for (var i = 0; i < stickiesArray.length; i++) {
        var key = stickiesArray[i];
        var value = JSON.parse(localStorage[key]);
        addStickyToDOM(key, value);
    }
}

function addStickyToDOM(key, stickyObj) {
    var stickies = document.getElementById("stickies");
    var sticky = document.createElement("li");
    sticky.style.backgroundColor = stickyObj.color;
    sticky.setAttribute("id", key);
    var span = document.createElement("span");
    span.setAttribute("class", "sticky");
    span.innerHTML = stickyObj.value;
    sticky.appendChild(span);
    stickies.appendChild(sticky);
    sticky.onclick = deleteSticky;
}

function createSticky() {
    var stickiesArray = getStickiesArray();
    currentDate = new Date();
    var key = "sticky_" + currentDate.getTime();
    var selectedColor = document.getElementById("note_color");
    var index = selectedColor.selectedIndex;
    var color = selectedColor[index].value;
    var value = document.getElementById("note_text").value.trim();
    if (!value) {
        alert("Input your sticky below!");
    }
    else {
        stickyObj = {
            "value": value,
            "color": color
        };
        localStorage.setItem(key, JSON.stringify(stickyObj));
        stickiesArray.push(key);
        localStorage.setItem("stickiesArray", JSON.stringify(stickiesArray));
        addStickyToDOM(key, stickyObj);
        var clearInput = document.getElementById("note_text");
        clearInput.value = "";
    }
}

function getStickiesArray() {
    var stickiesArray = localStorage.getItem("stickiesArray");
    if (!stickiesArray) {
        stickiesArray = [];
        localStorage.setItem("stickiesArray", JSON.stringify(stickiesArray));
    }
    else {
        stickiesArray = JSON.parse(stickiesArray);
    }
    return stickiesArray;
}

function deleteSticky(e) {
    var key = e.target.id;
    if (e.target.tagName.toLowerCase() == "span") {
        key = e.target.parentNode.id;
    }
    localStorage.removeItem(key);
    var stickiesArray = getStickiesArray();
    if (stickiesArray) {
        for (let index = 0; index < stickiesArray.length; index++) {
            if (key == stickiesArray[index]) {
                stickiesArray.splice(index, 1);
            }
        }
    }
    localStorage.setItem("stickiesArray", JSON.stringify(stickiesArray));
    removeStickyFromDOM(key);
}

function removeStickyFromDOM(key) {
    var sticky = document.getElementById(key);
    sticky.parentNode.removeChild(sticky);
}