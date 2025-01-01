
function checkInput() {
    const input = document.getElementById('cityInput').value.trim().toLowerCase();
    const additionalField = document.getElementById('additionalField');
    const keywords = ["kyiv", "kiev", "київ", "киев", "києв", "кієв"];

    if (keywords.includes(input)) {
        additionalField.style.display = 'block';
    } else {
        additionalField.style.display = 'none';
    }
}