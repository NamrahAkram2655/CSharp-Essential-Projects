let postData = [];

document.addEventListener("DOMContentLoaded", () => {
    fetch("data.json")
        .then(response => response.json())
        .then(data => {
            postData = data;
            displayTable(postData);
        })
        .catch(error => console.error("Error fetching data:", error));

    document.getElementById("searchInput").addEventListener("input", function () {
        const searchText = this.value.toLowerCase();
        const filtered = postData.filter(post => post.title.toLowerCase().includes(searchText));
        displayTable(filtered);
    });
});

function displayTable(data) {
    const tbody = document.querySelector("#postTable tbody");
    tbody.innerHTML = "";

    data.forEach(post => {
        const row = `<tr>
                        <td>${post.id}</td>
                        <td>${post.title}</td>
                        <td>${post.body}</td>
                     </tr>`;
        tbody.innerHTML += row;
    });
}
