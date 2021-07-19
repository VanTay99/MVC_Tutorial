
// demo Ajax voi file text
function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/Content/txt/ajax_info.txt", true);
    xhttp.send();

}
// demo Ajax voi file xml
function loadXML() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        const xmlDoc = this.responseXML;
        const x = xmlDoc.getElementsByTagName("ARTIST");
        let txt = "";
        for (let i = 0; i < x.length; i++) {
            txt = txt + x[i].childNodes[0].nodeValue + "<br>";
        }
        document.getElementById("demo").innerHTML = txt;
    }
    xhttp.open("GET", "/Content/xml/ajax_info.xml");
    xhttp.send();
}
// demo Ajax voi file asp
function loadASP(str) {
    var xhttp;
    if (str.length == 0) {
        document.getElementById("txtHint").innerHTML = "";
        return;
    }
    xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("txtHint").innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/Content/asp/gethint.asp?q=" + str, true);
    xhttp.send();
}
//#region demo Ajax Jquery
//Ajax khong dong bo
$(document).ready(function () {
    $("#button1").click(function () {
        $.ajaxSetup({
            url: "/Content/txt/ajax_info.txt", success: function (result) {
                $("#div1").html(result);
            }
        });
        $.ajax();
    });
});

$(document).ready(function () {
    $("#button2").click(function () {
        $.get("/Content/asp/gethint.asp",function (data, status) {
            alert("Data: " + data + "\nStatus: " + status);
        });
    });
});


//#endregion 
