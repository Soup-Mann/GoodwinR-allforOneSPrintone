// function withCors() {
//     fetch('https://goodwinrallforone.azurewebsites.net/AllForOne/addTwo/').then(
//         responce => responce.text()
//     ).then(
//         data => console.log(data)
//     )
// }
// withCors()


let numInput = document.getElementById("numInput");
let numTwoInput = document.getElementById("numTwoInput");
let AddTwoReturn = document.getElementById("AddTwoReturn");
let AddTwoBut = document.getElementById("AddTwoBut");

let savedInput = "";
let savedInputTwo = "";
let AddTwoUrl = "";
let response = "";

AddTwoBut.addEventListener("click", function () {
  AddTwoApi(numInput, numTwoInput)
    AddTwoReturn.textContent = response
     console.log("what")
    })
   
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                AddTwoReturn.textContent = data
                console.log(data)
            }
        )
    }

function AddTwoApi(numInput, numTwoInput){
   
    
        savedInput = numInput.value;
        savedInputTwo = numTwoInput.value;
        AddTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/addTwo/" + savedInput + "/" + savedInputTwo;
        urlCall(AddTwoUrl)
   
}
// function AddTwoApiTwo(numTwoInput){
  

//         savedInput = nameInput.value;
//         AddTwoUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/addTwo/" + savedInput;
//         urlCall(AddTwoUrl)
   
// }