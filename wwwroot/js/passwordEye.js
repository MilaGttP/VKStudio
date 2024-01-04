function togglePasswordVisibility() {
    var passwordInput = document.getElementById("passwordInput");
    var togglePassword = document.getElementById("togglePassword");

    if (passwordInput.type === "password") {
        passwordInput.type = "text"; 
        togglePassword.innerHTML = "&#10006;";
    } else {
        passwordInput.type = "password";
        togglePassword.innerHTML = "&#128065;";
    }
}