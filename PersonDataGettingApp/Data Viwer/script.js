
        fetch('data.json')
        .then(response => response.json())
        .then(data => {
            const table = document.getElementById("personTable").getElementsByTagName('tbody')[0];

            data.forEach(person => {
                const row = table.insertRow();
                row.innerHTML = `<td>${person.Name}</td><td>${person.Age}</td><td>${person.Email}</td>`;
            });
        })
        .catch(error => {
            console.error('Error loading data.json:', error);
        });


    function sortTable(colIndex) {
        const table = document.getElementById("personTable");
        let rows = Array.from(table.rows).slice(1);
        let asc = table.getAttribute("data-sort") !== "asc";

        rows.sort((a, b) => {
            const x = a.cells[colIndex].innerText;
            const y = b.cells[colIndex].innerText;
            return asc ? x.localeCompare(y) : y.localeCompare(x);
        });

        table.setAttribute("data-sort", asc ? "asc" : "desc");

        rows.forEach(row => table.appendChild(row));
    }
    
