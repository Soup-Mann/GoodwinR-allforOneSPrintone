let askInput = document.getElementById("askInput");
let askTwoInput = document.getElementById("askTwoInput");
let askTwoReturn = document.getElementById("askTwoReturn");
let askTwoBut = document.getElementById("askTwoBut");

let savedInput = "";
let savedInputTwo = "";
let askTwoUrl = "";
let response = "";

askTwoBut.addEventListener("click", function () {
  askTwoApi(askInput, askTwoInput)
    askTwoReturn.textContent = response
    })
   
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                askTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function askTwoApi(askInput, askTwoInput){
   
    
        savedInput = askInput.value;
        savedInputTwo = askTwoInput.value;
        askTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/asking/" + savedInput + "/" + savedInputTwo;
        urlCall(askTwoUrl)
   
}