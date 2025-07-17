document.getElementById("registerForm").addEventListener("submit", async function (e) {
    e.preventDefault();
    const newUser = {
        name: registerName.value,
        email: registerEmail.value,
        password: registerPassword.value,
        role: registerRole.value
    };

    const res = await fetch("/api/user/register", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(newUser)
    });

    if (res.ok) {
        alert("Registration successful. Please login.");
        window.location.href = "login.html";
    } else {
        alert("User already exists.");
    }
});
