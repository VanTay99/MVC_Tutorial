let result = document.getElementById('result');
var val
function handleChange() {
    result = document.getElementById('result');
}
function giam() {
    if (result.value > 1) {
        val = Number(result.value) - 1;
    }
    else val = 1;
    result.setAttribute('value',val)
}
function tang() {
    val = Number(result.value) + 1;
    result.setAttribute('value', val);
    
}