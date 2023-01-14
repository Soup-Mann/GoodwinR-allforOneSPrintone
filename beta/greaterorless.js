
let greaterInput = document.getElementById("greaterInput");
let greaterTwoInput = document.getElementById("greaterTwoInput");
let greaterTwoReturn = document.getElementById("greaterTwoReturn");
let greaterTwoBut = document.getElementById("greaterTwoBut");

let savedInput = "";
let savedInputTwo = "";
let greaterTwoUrl = "";
let response = "";

greaterTwoBut.addEventListener("click", function () {
  greaterTwoApi(greaterInput, greaterTwoInput)
    greaterTwoReturn.textContent = response
    })
   
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                greaterTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function greaterTwoApi(greaterInput, greaterTwoInput){
   
    
        savedInput = greaterInput.value;
        savedInputTwo = greaterTwoInput.value;
        greaterTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/greaterOrLess/" + savedInput + "/" + savedInputTwo;
        urlCall(greaterTwoUrl)
   
}