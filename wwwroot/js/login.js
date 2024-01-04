document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("loginButton").addEventListener("click", function () {
        var enteredLogin = document.getElementById("loginInput").value;
        var enteredPassword = document.getElementById("passwordInput").value;

        $.ajax({
            url: '/Login',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({ login: enteredLogin, password: enteredPassword }),
            success: function (result) {
                if (result.success) {
                    window.location.href = '/ChoosePhotos';
                } else {
                    alert('Неправильний логін або пароль. Спробуйте ще раз.');
                }
            },
            error: function (xhr, status, error) {
                if (xhr.status === 400) {
                    alert('Неправильний логін або пароль. Спробуйте ще раз.');
                } else if (xhr.status === 500) {
                    alert('Внутрішня помилка сервера. Спробуйте пізніше.');
                } else {
                    alert('Сталася невідома помилка. Спробуйте пізніше.');
                }
            }
        });
    });
});