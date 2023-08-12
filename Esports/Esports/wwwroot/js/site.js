// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var popupbox = document.getElementById("popupbox");
var closeBtn = document.getElementById("close-popup-box");
var openTopButton = document.getElementById("Add-Player-Button-Top");
var openJngButton = document.getElementById("Add-Player-Button-Jng");
var openMidButton = document.getElementById("Add-Player-Button-Mid");
var openAdcButton = document.getElementById("Add-Player-Button-Adc");
var openSupButton = document.getElementById("Add-Player-Button-Sup");

var target = document.getElementById("target");

var gameOneBtn = document.getElementsByClassName("dropbtn1");
var gameTwoBtn = document.getElementsByClassName("dropbtn2");
var gameThreeBtn = document.getElementsByClassName("dropbtn3");
var gameFourBtn = document.getElementsByClassName("dropbtn4");
var gameFiveBtn = document.getElementsByClassName("dropbtn5");


function setAdmin(name, gameNum) {
    switch (gameNum) {
        case 1: gameOneBtn[0].innerHTML = name; break;
        case 2: gameTwoBtn[0].innerHTML = name; break;
        case 3: gameThreeBtn[0].innerHTML = name; break;
        case 4: gameFourBtn[0].innerHTML = name; break;
        case 5: gameFiveBtn[0].innerHTML = name; break;

        default:
    }
}

function saveDaily() {

    var admWarningText = document.getElementById("admWarningText");

    if (gameOneBtn[0].innerHTML != 'Game 1' &&
        gameTwoBtn[0].innerHTML != 'Game 2' &&
        gameThreeBtn[0].innerHTML != 'Game 3' &&
        gameFourBtn[0].innerHTML != 'Game 4' &&
        gameFiveBtn[0].innerHTML != 'Game 5') {

        var winners = [gameOneBtn[0].innerHTML, gameTwoBtn[0].innerHTML, gameThreeBtn[0].innerHTML, gameFourBtn[0].innerHTML, gameFiveBtn[0].innerHTML];

        $.ajax({
            url: "/Administrator/GivePoints",
            type: "Post",
            data: { 'winners': winners },
            success: function () {
                location.reload();
            },
            error: function () {

            }
        })


    } else {
        admWarningText.innerHTML = "Please select all five games before saving!"
    }
}

    
if (openTopButton != null) {
    openTopButton.addEventListener("click", () => {
        popupbox.classList.add("open");
    });
}

if (openJngButton!= null) {
    openJngButton.addEventListener("click", () => {
        popupbox.classList.add("open");
    });
}

if (openMidButton != null) {
    openMidButton.addEventListener("click", () => {
        popupbox.classList.add("open");
    });
}

if (openAdcButton != null) {
    openAdcButton.addEventListener("click", () => {
        popupbox.classList.add("open");
    });
}

if (openSupButton != null) {
    openSupButton.addEventListener("click", () => {
        popupbox.classList.add("open");
    });
}

if (closeBtn != null) {
    closeBtn.addEventListener("click", () => {
        popupbox.classList.remove("open");
    });
}




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






