window.onload = function () {
    var Atag = document.getElementsByTagName('a');
    var MainPic = document.getElementsByTagName ('MainPicture')
    var Exit = document.getElementById('SuccessButton')
    var upLoad = document.getElementsByTagName('SendButton')
    var Info = document.getElementById('SuccessBox')
    console.log(Atag[0] + ' : ' + window.location.href);

    for (var i = 0; i < Atag.length; i++){
        if(Atag[i].href == window.location.href)
        {
            Atag[i].style.backgroundColor = "red";
        }
    }
    Exit.onclick = function () {
        Info.parentNode.removeChild(Info);
    }
};