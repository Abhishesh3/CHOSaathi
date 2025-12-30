function isValidEmailAddress(emailAddress) {
    var pattern = new RegExp(/^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i);
    return pattern.test(emailAddress);
}

function isValidMobileNumber(mobile) {
    var pattern = /^[6-9]\d{9}$/;
    return pattern.test(mobile);
}

function Validate(actionType) {
    var username = $("#UserName").val().trim();
    var role = $("#RoleId").val().trim();
    var name = $("#Name").val().trim();
    var email = $("#EmailId").val().trim();
    var mobile = $("#MobileNo").val().trim();
    var hasError = false;

    if (actionType === "save") {
        var password = $("#Password").val().trim();

        if (username === "") {
            if (!hasError) $("#UserName").focus();
            $("#UserName").addClass("is-invalid");
            $("span[data-valmsg-for='UserName']").text("Username is required.");
            hasError = true;
        } else {
            $("#UserName").removeClass("is-invalid");
            $("span[data-valmsg-for='UserName']").text("");
        }

        if (password === "") {
            if (!hasError) $("#Password").focus();
            $("#Password").addClass("is-invalid");
            $("span[data-valmsg-for='Password']").text("Password is required.");
            hasError = true;
        } else {
            $("#Password").removeClass("is-invalid");
            $("span[data-valmsg-for='Password']").text("");
        }

        if (role === "") {
            if (!hasError) $("#RoleId").focus();
            $("#RoleId").addClass("is-invalid");
            $("span[data-valmsg-for='RoleId']").text("Role selection is required.");
            hasError = true;
        } else {
            $("#RoleId").removeClass("is-invalid");
            $("span[data-valmsg-for='RoleId']").text("");
        }

        if (name === "") {
            if (!hasError) $("#Name").focus();
            $("#Name").addClass("is-invalid");
            $("span[data-valmsg-for='FullName']").text("Name is required.");
            hasError = true;
        } else {
            $("#Name").removeClass("is-invalid");
            $("span[data-valmsg-for='FullName']").text("");
        }

        if (mobile !== "") {
            if (!isValidMobileNumber(mobile)) {
                if (!hasError) $("#MobileNo").focus();
                $("#MobileNo").addClass("is-invalid");
                $("span[data-valmsg-for='Mobile']").text("Please enter a valid 10-digit number starting with 6, 7, 8, or 9.");
                hasError = true;
            } else {
                $("#MobileNo").removeClass("is-invalid");
                $("span[data-valmsg-for='Mobile']").text("");
            }
        } else {
            $("#MobileNo").removeClass("is-invalid");
            $("span[data-valmsg-for='Mobile']").text("");
        }

        if (email !== "") {
            if (!isValidEmailAddress(email)) {
                if (!hasError) $("#EmailId").focus();
                $("#EmailId").addClass("is-invalid");
                $("span[data-valmsg-for='EmailId']").text("Please enter a valid email address.");
                hasError = true;
            } else {
                $("#EmailId").removeClass("is-invalid");
                $("span[data-valmsg-for='EmailId']").text("");
            }
        } else {
            $("#EmailId").removeClass("is-invalid");
            $("span[data-valmsg-for='EmailId']").text("");
        }

        // CASE-SENSITIVE CHECK via AJAX
        if (!hasError) {
            $.ajax({
                url: '/Users/CheckUsernameCaseSensitive',
                type: 'GET',
                data: { username: username },
                success: function (exists) {
                    if (exists) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Error',
                            text: 'Username already exists.',
                            toast: true,
                            position: 'top',
                            showConfirmButton: false,
                            timer: 3000,
                            timerProgressBar: true
                        });
                    } else {
                        $("#form").submit();
                    }
                },
                error: function () {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'Username already exist.',
                        toast: true,
                        position: 'top',
                        showConfirmButton: false,
                        timer: 3000,
                        timerProgressBar: true
                    });
                }
            });
        }
    }
    else if (actionType === "update") {
        hasError = false;

        if (name === "") {
            if (!hasError) $("#Name").focus();
            $("#Name").addClass("is-invalid");
            $("span[data-valmsg-for='FullName']").text("Name is required.");
            hasError = true;
        } else {
            $("#Name").removeClass("is-invalid");
            $("span[data-valmsg-for='FullName']").text("");
        }

        if (mobile !== "") {
            if (!isValidMobileNumber(mobile)) {
                if (!hasError) $("#MobileNo").focus();
                $("#MobileNo").addClass("is-invalid");
                $("span[data-valmsg-for='Mobile']").text("Please enter a valid 10-digit number starting with 6, 7, 8, or 9.");
                hasError = true;
            } else {
                $("#MobileNo").removeClass("is-invalid");
                $("span[data-valmsg-for='Mobile']").text("");
            }
        } else {
            $("#MobileNo").removeClass("is-invalid");
            $("span[data-valmsg-for='Mobile']").text("");
        }

        if (email !== "") {
            if (!isValidEmailAddress(email)) {
                if (!hasError) $("#EmailId").focus();
                $("#EmailId").addClass("is-invalid");
                $("span[data-valmsg-for='EmailId']").text("Please enter a valid email address.");
                hasError = true;
            } else {
                $("#EmailId").removeClass("is-invalid");
                $("span[data-valmsg-for='EmailId']").text("");
            }
        } else {
            $("#EmailId").removeClass("is-invalid");
            $("span[data-valmsg-for='EmailId']").text("");
        }

        if (!hasError) {
            $("#form").submit();
        }
    }
    return false; // prevent default click action
}
