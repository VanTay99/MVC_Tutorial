
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