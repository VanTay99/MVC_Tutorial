
let inputValue = document.getElementById('inputValue');
var newVal;
const xhttp = new XMLHttpRequest();
xhttp.status
function handleChange() {
    inputValue = document.getElementById('inputValue');
    alert(inputValue.value);
}
function giam() {
    var result = document.getElementById('quantity');
    var qty = result.value;
    if (!isNaN(qty) &  qty > 1 )
    result.value--;
    return false;
}
function tang() {
    var result = document.getElementById('quantity');
    var qty = result.value;
    if (!isNaN(qty)) result.value++;
    return false;
    
}