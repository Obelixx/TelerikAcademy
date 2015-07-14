function checkForMozilla() {
    var myWindow = window,
        onBrowser = myWindow.navigator.appCodeName,
        isMozilla = onBrowser === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}