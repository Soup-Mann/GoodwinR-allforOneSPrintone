

let nameInput = document.getElementById("nameInput");
let nameSubBtn = document.getElementById("nameSubBtn");

let lastNameInput = document.getElementById("lastNameInput");
let lastNameSubBtn = document.getElementById("lastNameSubBtn");

let slackInput = document.getElementById("slackInput");
let slackSubBtn = document.getElementById("slackSubBtn");


let nameReturn = document.getElementById("nameReturn");
let savedInput = "";
let NameUrl = "";



//THis is FIrst name
nameSubBtn.addEventListener("click", function () {
    NameApi(nameInput)

    })
    
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                nameReturn.textContent = data
                console.log(data)
            }
        )
    }

function NameApi(nameInput){

        savedInput = nameInput.value;
        NameUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/GetStudentByFirstName/" + savedInput;
        urlCall(NameUrl)
}


//Last name

lastNameSubBtn.addEventListener("click", function () {
    lastNameApi(lastNameInput)

    })
    
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                nameReturn.textContent = data
                console.log(data)
            }
        )
    }

function lastNameApi(nameInput){

        savedInput = nameInput.value;
        lastNameUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/GetStudentByLastName/" + savedInput;
        urlCall(lastNameUrl)
}


slackSubBtn.addEventListener("click", function () {
    slackNameApi(slackInput)

    })
    
    function urlCall(url) {
        fetch(url).then(
            response => response.text()
        ).then(
            data => {
                nameReturn.textContent = data
                console.log(data)
            }
        )
    }

function slackNameApi(slackInput){

        savedInput = slackInput.value;
        slackNameUrl = "https://goodwinrallforone.azurewebsites.net/AllForOne/GetStudentBySlackName/" + savedInput;
        urlCall(slackNameUrl)
}