var connection = new signalR.HubConnectionBuilder().withUrl("/ExerciseHub").build();

//Disable send button until connection is established
document.getElementById("positive").disabled = true;
document.getElementById("negative").disabled = true;

connection.on("sendExercise", function (name, instructions) {
    var msg = name.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    document.getElementById("Name").textContent = msg;
    document.getElementById("Instructions").textContent = instructions;
});

connection.start().then(function () {
    document.getElementById("positive").disabled = false;
    document.getElementById("negative").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("positive").addEventListener("click", function (event) {
    connection.invoke("sendExerciseFeedback", "0.1").catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
document.getElementById("negative").addEventListener("click", function (event) {
    connection.invoke("sendExerciseFeedback", "-0.1").catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});