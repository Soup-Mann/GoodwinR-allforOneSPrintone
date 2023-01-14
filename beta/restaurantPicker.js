let resInput = document.getElementById("resInput");
let resTwoReturn = document.getElementById("resTwoReturn");
let resTwoBut = document.getElementById("resTwoBut");

let savedInput = "";
let resTwoUrl = "";
let response = "";

resTwoBut.addEventListener("click", function () {
  resTwoApi(resInput,)
    resTwoReturn.textContent = response
    })
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                resTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function resTwoApi(resInput){
   
    
        savedInput = resInput.value;
        resTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/Restaurant/" + savedInput;
        urlCall(resTwoUrl)
   
}