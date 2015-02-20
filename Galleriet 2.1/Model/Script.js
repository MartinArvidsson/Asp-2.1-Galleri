window.onload = function () {
    var Atag = document.getElementsByTagName('a');
    var MainPic = document.getElementsByTagName ('MainPicture')
    var Exit = document.getElementsByTagName('SuccessButton')
    var upLoad = document.getElementsByTagName('SendButton')
    var Info = document.getElementsByTagName('SuccessBox')

    for (var i = 0; i < Atag.length; i++){
        if(Atag[i] == window.location.href)
        {
            Atag[i].style.backgroundcolor = "red";
        }
        Exit.onclick= function()
        {
            Info.parentNode.removeChild(Info);
        }
    }
};