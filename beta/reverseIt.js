let reverseInput = document.getElementById("reverseInput");
let reverseTwoReturn = document.getElementById("reverseTwoReturn");
let reverseTwoBut = document.getElementById("reverseTwoBut");

let savedInput = "";
let reverseTwoUrl = "";
let response = "";

reverseTwoBut.addEventListener("click", function () {
  reverseTwoApi(reverseInput,)
    reverseTwoReturn.textContent = response
    })
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                reverseTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function reverseTwoApi(reverseInput){
   
    
        savedInput = reverseInput.value;
        reverseTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/reverseIt/" + savedInput;
        urlCall(reverseTwoUrl)
   
}