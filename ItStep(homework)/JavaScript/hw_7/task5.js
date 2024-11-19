function generateCalendar() {
    const month = parseInt(document.getElementById("month").value) - 1;
    const year = parseInt(document.getElementById("year").value);

    const firstDay = new Date(year, month, 1);
    const lastDay = new Date(year, month + 1, 0);

    const calendarBody = document.querySelector("#calendar tbody");
    calendarBody.innerHTML = "";

    document.getElementById("month-year").innerText = firstDay.toLocaleString('uk-UA', { month: 'long', year: 'numeric' });

    let row = document.createElement("tr");
    let dayOfWeek = firstDay.getDay() || 7; 
    for (let i = 1; i < dayOfWeek; i++) {
        let emptyCell = document.createElement("td");
        row.appendChild(emptyCell);
    }

    for (let day = 1; day <= lastDay.getDate(); day++) {
        let cell = document.createElement("td");
        cell.innerText = day;
        row.appendChild(cell);

        if ((dayOfWeek % 7) === 0 || day === lastDay.getDate()) {
            calendarBody.appendChild(row);
            row = document.createElement("tr");
        }
        dayOfWeek++;
    }
}
