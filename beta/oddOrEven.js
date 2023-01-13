// function withCors() {
//     fetch('https://goodwinrallforone.azurewebsites.net/AllForOne/oddOrEven').then(
//         responce => responce.text()
//     ).then(
//         data => console.log(data)
//     )
// }


let OddInput = document.getElementById("OddInput");
let OddReturn = document.getElementById("OddReturn");
let OddSubBtn = document.getElementById("OddSubBtn");

let savedInput = "";
let OddUrl = "";

OddSubBtn.addEventListener("click", function () {
    OddApi(OddInput)

    })
    
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                OddReturn.textContent = data;
                console.log(data);
            }
        )
    }

function OddApi(OddInput){
    
        savedInput = OddInput.value;
        OddUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/oddOrEven/" + savedInput;
        urlCall(OddUrl)
   
}

//withCors()