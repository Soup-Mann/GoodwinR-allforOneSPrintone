function withCors() {
    fetch('https://markallforone.azurewebsites.net/OodOrEven/EvenOrOod/7').then(
        responce => responce.text()
    ).then(
        data => console.log(data)
    )
}
withCors()