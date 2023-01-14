let madInput = document.getElementById("madInput");
let madTwoInput = document.getElementById("madTwoInput");
let madThreeInput = document.getElementById("madThreeInput");
let madFourInput = document.getElementById("madFourInput");
let madFiveInput = document.getElementById("madFiveInput");
let madSixInput = document.getElementById("madSixInput");
let madSevenInput = document.getElementById("madSevenInput");
let madEightInput = document.getElementById("madEightInput");
let madNineInput = document.getElementById("madNineInput");
let madTenInput = document.getElementById("madTenInput");





let madTwoReturn = document.getElementById("madTwoReturn");



let madTwoBut = document.getElementById("madTwoBut");

let savedInput = "";
let madInputTwo = "";
let madInputThree = "";
let madInputFour = "";
let madInputFive = "";
let madInputSix = "";
let madInputSeven = "";
let madInputEight = "";
let madInputNine = "";
let madInputTen = "";
let madTwoUrl = "";
let response = "";

madTwoBut.addEventListener("click", function () {
  madTwoApi(madInput, madTwoInput, madThreeInput, madFourInput, madFiveInput, madSixInput, madSevenInput, madEightInput, madNineInput, madTenInput)
    madTwoReturn.textContent = response
     console.log("what")
    })
   
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                madTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function madTwoApi(madInput, madTwoInput, madThreeInput, madFourInput, madFiveInput, madSixInput, madSevenInput, madEightInput, madNineInput, madTenInput){
   
    
        savedInput = madInput.value;
        madInputThree = madTwoInput.value;
        madInputThree = madThreeInput.value;
        madInputFour = madFourInput.value;
        madInputFive = madFiveInput.value;
        madInputSix = madSixInput.value;
        madInputSeven = madSevenInput.value;
        madInputEight = madEightInput.value;
        madInputNine = madNineInput.value;
        madInputTen = madTenInput.value;
        madTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/madLib/" + savedInput + "/" + madInputTwo + "/" + madInputThree + "/" + madInputFour + "/" + madInputFive + "/" + madInputSix + "/" + madInputSeven + "/" + madInputEight + "/" + madInputNine + "/" + madInputTen;
        urlCall(madTwoUrl)
   
}