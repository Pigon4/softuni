// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var popupbox = document.getElementById("popupbox");
var openBtn = document.getElementById("Add-Player-Button");
var closeBtn = document.getElementById("close-popup-box");

var target = document.getElementById("target");



openBtn.addEventListener("click", () => {
    popupbox.classList.add("open");
});

closeBtn.addEventListener("click", () => {
    popupbox.classList.remove("open");
});





function AddPlayer(name) {
    $.ajax({
        url: "/UserTeam/AddPlayer",
        type: "GET",
        datatype: "text",
        data: { 'plName': name },
        success: function (data) {
            location.reload();
        },
        error: function () {

        }
    })
}


$("#topBtn").unbind("click").bind("click", () => {

    addRemoveBorders("topBtn");

    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'top' },
        success: function (data) {
            var htmlString = "";
            for (var i = 0; i < data.length; i++) {
                htmlString += "<div id=\"popup-image-text-container\"><img id=\"team-popupbox-image\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname +"\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> </div>"
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })


})

$("#jngBtn").unbind("click").bind("click", () => {

    addRemoveBorders("jngBtn");

    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'jng' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<div id=\"popup-image-text-container\"><img id=\"team-popupbox-image\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname + "\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> </div>"  }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#midBtn").unbind("click").bind("click", () => {

    addRemoveBorders("midBtn");

    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'mid' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<div id=\"popup-image-text-container\"><img id=\"team-popupbox-image\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname + "\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> </div>"            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#adcBtn").unbind("click").bind("click", () => {

    addRemoveBorders("adcBtn");

    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'adc' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<div id=\"popup-image-text-container\"><img id=\"team-popupbox-image\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname + "\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> </div>"            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#supBtn").unbind("click").bind("click", () => {

    addRemoveBorders("supBtn");

    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'sup' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<div id=\"popup-image-text-container\"><img id=\"team-popupbox-image\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname + "\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> </div>"            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

function addRemoveBorders(btnString) {
    var topBtn = document.getElementById("topBtn");
    var jngBtn = document.getElementById("jngBtn");
    var midBtn = document.getElementById("midBtn");
    var adcBtn = document.getElementById("adcBtn");
    var supBtn = document.getElementById("supBtn");

    switch (btnString) {
        case "topBtn": topBtn.classList.add("selectedBorder"); jngBtn.classList.remove("selectedBorder");
            midBtn.classList.remove("selectedBorder"); adcBtn.classList.remove("selectedBorder"); supBtn.classList.remove("selectedBorder"); break;

        case "jngBtn": topBtn.classList.remove("selectedBorder"); jngBtn.classList.add("selectedBorder");
            midBtn.classList.remove("selectedBorder"); adcBtn.classList.remove("selectedBorder"); supBtn.classList.remove("selectedBorder"); break;

        case "midBtn": topBtn.classList.remove("selectedBorder"); jngBtn.classList.remove("selectedBorder");
            midBtn.classList.add("selectedBorder"); adcBtn.classList.remove("selectedBorder"); supBtn.classList.remove("selectedBorder"); break;

        case "adcBtn": topBtn.classList.remove("selectedBorder"); jngBtn.classList.remove("selectedBorder");
            midBtn.classList.remove("selectedBorder"); adcBtn.classList.add("selectedBorder"); supBtn.classList.remove("selectedBorder"); break;

        case "supBtn": topBtn.classList.remove("selectedBorder"); jngBtn.classList.remove("selectedBorder");
            midBtn.classList.remove("selectedBorder"); adcBtn.classList.remove("selectedBorder"); supBtn.classList.add("selectedBorder"); break;

    }

}




