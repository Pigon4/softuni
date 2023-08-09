// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var popupbox = document.getElementById("popupbox");
var closeBtn = document.getElementById("closeBtn");
var openBtn = document.getElementById("Add-Player-Button");

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
    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'top' },
        success: function (data) {
            var htmlString = "";
            for (var i = 0; i < data.length; i++) {
                htmlString += "<img id=\"pic\" src=\"" + data[i].image + "\" onclick=\"AddPlayer(\'" + data[i].nickname +"\')\"></img><div id=\"name\" style:absolute>" + data[i].nickname + "</div> "
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })


})

$("#jngBtn").unbind("click").bind("click", () => {
    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'jng' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<img id=\"pic\" src=\"" + data[i].image + "\"></img><div style:absolute>" + data[i].nickname + "</div> "
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#midBtn").unbind("click").bind("click", () => {
    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'mid' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<img id=\"pic\" src=\"" + data[i].image + "\"></img><div style:absolute>" + data[i].nickname + "</div> "
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#adcBtn").unbind("click").bind("click", () => {
    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'adc' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<img id=\"pic\" src=\"" + data[i].image + "\"></img><div style:absolute>" + data[i].nickname + "</div> "
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})

$("#supBtn").unbind("click").bind("click", () => {
    $.ajax({
        url: "/UserTeam/UserPlayers",
        datatype: "json",
        type: "POST",
        data: { 'position': 'sup' },
        success: function (data) {
            var htmlString = "";

            for (var i = 0; i < data.length; i++) {
                htmlString += "<img id=\"pic\" src=\"" + data[i].image + "\"></img><div style:absolute>" + data[i].nickname + "</div> "
            }

            target.innerHTML = htmlString;
        },
        error: function () {

        }
    })
})






