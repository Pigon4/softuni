// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const popupbox = document.getElementById("popupbox");
const closeBtn = document.getElementById("closeBtn");
const openBtn = document.getElementById("Add-Player-Button");



openBtn.addEventListener("click", () => {
    popupbox.classList.add("open");
});

closeBtn.addEventListener("click", () => {
    popupbox.classList.remove("open");
});

