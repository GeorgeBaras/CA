if (window.localStorage.getItem("globalLanguage") !== 'en' && window.localStorage.getItem("globalLanguage") !== 'gr') {
    console.log('1.Got into the first if...');
    setGlobalLanguage('en');
    window.location.reload();
}


function setGlobalLanguage(language) {
    window.localStorage.setItem("globalLanguage", language.toString());
    console.log('Created localStorage');
}

function setToEnglish() {
    setGlobalLanguage('en');
    window.location.reload();
}

function setToGreek() {
    setGlobalLanguage('gr');
    window.location.reload();
}

function hideDivIfNotCorrectLanguage() {
    if (window.localStorage.getItem("globalLanguage").toString() === 'en') {
        var divsToHide = document.getElementsByClassName("gr");
        console.log('found ' + divsToHide.length + ' en elements');
        for (var i = 0; i < divsToHide.length; i++) {
            divsToHide[i].style.display = "none";
        }
        var divsToHide2 = document.getElementsByClassName("en");
        for (var j = 0; j < divsToHide2.length; j++) {
            divsToHide2[j].style.display = "";
        }
    }

    if (window.localStorage.getItem("globalLanguage").toString() === 'gr') {
        var divsToHide3 = document.getElementsByClassName("en");
        console.log('found ' + divsToHide3.length + ' gr elements');
        for (var k = 0; k < divsToHide3.length; k++) {
            divsToHide3[k].style.display = "none";
        }
        var divsToHide4 = document.getElementsByClassName("gr");
        for (var l = 0; l < divsToHide4.length; l++) {
            divsToHide4[l].style.display = "";
        }
    }
}


    