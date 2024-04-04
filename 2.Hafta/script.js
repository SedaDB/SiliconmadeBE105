// İsim Bölümü
function isimKutusu() {
    let isimGiris = document.getElementById('adGir');
    let isimSonuc = document.getElementById('ad');
    let isimGirisi = isimGiris.value;
    isimSonuc.innerText = isimGirisi;
}
function unvanKutusu() {
    let unvanGiris = document.getElementById('unGir');
    let unvanSonuc = document.getElementById('un');
    let unvanGirisi = unvanGiris.value;
    unvanSonuc.innerText = unvanGirisi;
}

// İletişim Bölümü
function telKutusu() {
    let telGiris = document.getElementById('telGir');
    let telSonuc = document.getElementById('tel');
    let telGirisi = telGiris.value;
    telSonuc.innerText = telGirisi;
}
function mailKutusu() {
    let mailGiris = document.getElementById('mailGir');
    let mailSonuc = document.getElementById('mail');
    let mailGirisi = mailGiris.value;
    mailSonuc.innerText = mailGirisi;
}
function webKutusu() {
    let webGiris = document.getElementById('webGir');
    let webSonuc = document.getElementById('web');
    let webGirisi = webGiris.value;
    webSonuc.innerText = webGirisi;
}
function adresKutusu() {
    let adresGiris = document.getElementById('adresGir');
    let adresSonuc = document.getElementById('adres');
    let adresGirisi = adresGiris.value;
    adresSonuc.innerText = adresGirisi;
}
//Eğitim Bölümü
function egitimAciklama() {
    let egitimGiris = document.getElementById('acik1');
    let egitimSonuc = document.getElementById('edu');
    let egitimGirisi = egitimGiris.value;
    egitimSonuc.innerText = egitimGirisi;
}

    function okulSayiSecim() {
        const selectElement = document.getElementById("okulSayi");
    const selectedValue = selectElement.value;
    const inputElements = document.querySelectorAll(".o1, .o2, .o3, .o4");
    const listElements = document.querySelectorAll("#li1, #li2, #li3, #li4");

    inputElements.forEach((element) => {
        element.style.display = "none";
    });
    listElements.forEach((element) => {
        element.style.display = "none";
    })

    for (let i = 1; i <= selectedValue; i++) {
        const inputElement = document.querySelector(`.o${i}`);
        inputElement.style.display = "table-row";
        const listElement = document.querySelector(`#li${i}`);
        listElement.style.display = "list-item";
    }
        
    }

    function giris(girisId, sonucId) {
    let giris = document.getElementById(girisId);
    let sonuc = document.getElementById(sonucId);
    let girisi = giris.value;
    sonuc.innerText = girisi;
    }
    function girisOkul(girisId, sonucId, aciklamaId) {
        let giris = document.getElementById(girisId);
        let aciklamaInput = document.getElementById(aciklamaId);
        let sonucLi = document.getElementById(sonucId);
        let okul = giris.value.trim();
        let aciklama = aciklamaInput.value.trim();
        sonucLi.innerText = okul + (aciklama ? ' - ' + aciklama : ''); // Eğer açıklama varsa ekle
    }
    function girisAciklama(girisId, sonucId, aciklamaId) {
        let giris = document.getElementById(aciklamaId);
        let okulInput = document.getElementById(girisId); 
        let sonucLi = document.getElementById(sonucId);
        let okul = okulInput.value.trim();
        let aciklama = giris.value.trim();
        sonucLi.innerText = okul + (aciklama ? ' º ' + aciklama : ''); // Eğer açıklama varsa ekle
    }
// Yetenek Bölümü
function yetSayiSecim() {
    const selectElementY = document.getElementById("yetSayi");
const selectedValueY = selectElementY.value;
const inputElementsY = document.querySelectorAll(".y1, .y2, .y3, .y4");
const listElementsY = document.querySelectorAll("#tli1, #tli2, #tli3, #tli4");

inputElementsY.forEach((element) => {
    element.style.display = "none";
});
listElementsY.forEach((element) => {
    element.style.display = "none";
})

for (let i = 1; i <= selectedValueY; i++) {
    const inputElementY = document.querySelector(`.y${i}`);
    inputElementY.style.display = "table-row";
    const listElementY = document.querySelector(`#tli${i}`);
    listElementY.style.display = "list-item";
}
    
}
// Görünüş Bölümü
function changeColor(colorId, className) {
    var colorInput = document.getElementById(colorId);
    var color = colorInput.value;
    document.querySelector(`.${className}`).style.backgroundColor = color;
}
function changeBaslikTextColor(newColor) {
    
    var adElement = document.getElementById("ad");
    var unElement = document.getElementById("un");
    var hrElement = document.querySelector('.baslik hr');

    adElement.style.color = newColor;
    unElement.style.color = newColor;
    
    hrElement.style.backgroundColor = newColor;
    hrElement.style.color = newColor;
}
function changeFontFamily() {
    var selectedFont = document.getElementById('YaziTipi').value;
    var classNameC = 'cv';

    var newFontFamily;
    switch (selectedFont) {
        case '1':
            newFontFamily = 'Times New Roman';
            break;
        case '2':
            newFontFamily = 'Courier New';
            break;
        case '3':
            newFontFamily = 'Lucida Handwriting';
            break;
    }

    var elements = document.getElementsByClassName(classNameC);
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.fontFamily = newFontFamily;
    }
}
function changeCevre() {
    var borderRadius = document.getElementById('Cevre').value;
    var classNameF = 'foto';

    var newBorderRadius;
    switch (borderRadius) {
        case '1':
            newBorderRadius = '0%';
            break;
        case '2':
            newBorderRadius = '20%';
            break;
        case '3':
            newBorderRadius = '50%';
            break;
    }

    document.querySelector(`.${classNameF}`).style.borderRadius = newBorderRadius;
}
function changeHrColor() {
    var lineColor = document.getElementById('lineColor').value;
    var hrElements = document.querySelectorAll('.headHr');

    hrElements.forEach(function(hr) {
        hr.style.borderColor = lineColor;
    });
}

function changeHrStyle() {
    var lineType = document.getElementById('lineType').value;
        var hrElements = document.querySelectorAll('.headHr');
        var lastLineColor = document.getElementById('lineColor').value;

        hrElements.forEach(function(hr) {
            switch (lineType) 
            {
                case '1':
                    hr.style.border = 'none';
                    hr.style.borderTop = '2px dotted';
                    hr.style.borderColor = lastLineColor;
                    break;
                case '2':
                    hr.style.border = 'none';
                    hr.style.borderTop = '2px dashed';
                    hr.style.borderColor = lastLineColor;
                    break;
                case '3':
                    hr.style.border = 'none';
                    hr.style.borderTop = '2px solid';
                    hr.style.borderColor = lastLineColor;
                    break;
            }
        });
    }