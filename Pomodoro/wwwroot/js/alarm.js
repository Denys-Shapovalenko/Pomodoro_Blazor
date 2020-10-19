window.WorkAlert = function () {
    let audio = document.querySelector("#alarm-notify");
    audio.play();
    window.setTimeout(function () {
        console.log("Alert!");
        audio.pause();
    }, 3000);
};
window.RestAlert = function () {
    let audio = document.querySelector("#alarm-notify");
    audio.play();
    window.setTimeout(function () {
        console.log("Alert!");
        audio.pause();
    }, 1000);
}