window.onload = init;

function init() {
    const button = document.getElementById("add_button");
    button.onclick = createSticky;
    const stickiesArray = getStickiesArray();
    for (let i = 0; i < stickiesArray.length; i++) {
        let key = stickiesArray[i];
        let value = JSON.parse(localStorage[key]);
        addStickyToDOM(key, value);
    }
}

function addStickyToDOM(key, stickyObj) {
    const stickies = document.getElementById("stickies");
    const sticky = document.createElement("li");
    sticky.style.backgroundColor = stickyObj.color;
    sticky.setAttribute("id", key);
    const span = document.createElement("span");
    span.setAttribute("class", "sticky");
    span.innerHTML = stickyObj.value;
    sticky.appendChild(span);
    stickies.appendChild(sticky);
    sticky.onclick = deleteSticky;
}

function createSticky() {
    const stickiesArray = getStickiesArray();
    currentDate = new Date();
    let key = "sticky_" + currentDate.getTime();
    let selectedColor = document.getElementById("note_color");
    let index = selectedColor.selectedIndex;
    let color = selectedColor[index].value;
    const value = document.getElementById("note_text").value.trim();
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
        const clearInput = document.getElementById("note_text");
        clearInput.value = "";
    }
}

function getStickiesArray() {
    let stickiesArray = localStorage.getItem("stickiesArray");
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
    let key = e.target.id;
    if (e.target.tagName.toLowerCase() == "span") {
        key = e.target.parentNode.id;
    }
    localStorage.removeItem(key);
    const stickiesArray = getStickiesArray();
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
    let sticky = document.getElementById(key);
    sticky.parentNode.removeChild(sticky);
}