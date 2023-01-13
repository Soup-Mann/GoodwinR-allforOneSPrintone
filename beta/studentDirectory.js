function withCors() {
    fetch('https://goodwinrallforone.azurewebsites.net/AllForOne').then(
        responce => responce.text()
    ).then(
        data => console.log(data)
    )
}
withCors()