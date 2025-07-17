document.getElementById("loginForm").addEventListener("submit", async function (e) {
    e.preventDefault();
    const user = {
        email: loginEmail.value,
        password: loginPassword.value
    };

    const res = await fetch("/api/user/login", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(user)
    });

    if (res.ok) {
        const data = await res.json();
        window.location.href = "dashboard.html";
    } else {
        alert("Login failed!");
    }
});
