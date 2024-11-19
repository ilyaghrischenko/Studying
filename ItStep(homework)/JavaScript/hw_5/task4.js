class StyledEmpTable extends EmpTable {
    getStyles() {
        return `
            <style>
                table { 
                    width: 100%; 
                    border-collapse: collapse; 
                    font-family: Arial, sans-serif; 
                }
                th, td { 
                    padding: 8px; 
                    text-align: left; 
                }
                th {
                    background-color: #4CAF50;
                    color: white;
                }
                tr:nth-child(even) { 
                    background-color: #f2f2f2; 
                }
            </style>
        `;
    }

    getHtml() {
        const originalHtml = super.getHtml();
        return this.getStyles() + originalHtml;
    }
}

const styledEmpTable = new StyledEmpTable(employees);
document.write(styledEmpTable.getHtml());