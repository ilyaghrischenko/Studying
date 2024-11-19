class ExtendedDate extends Date {
    getTextDate() {
        const months = [
            'січня', 'лютого', 'березня', 'квітня', 'травня', 'червня',
            'липня', 'серпня', 'вересня', 'жовтня', 'листопада', 'грудня'
        ];
        const day = this.getDate();
        const month = this.getMonth();
        return `${day} ${months[month]}`;
    }

    isFutureDate() {
        const today = new Date();
        return this >= today;
    }

    isLeapYear() {
        const year = this.getFullYear();
        return (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
    }

    getNextDate() {
        const nextDay = new Date(this);
        nextDay.setDate(this.getDate() + 1);
        return nextDay;
    }
}

const myDate = new ExtendedDate(2023, 9, 19);

console.log("Дата текстом:", myDate.getTextDate());
console.log("Майбутня чи поточна дата?", myDate.isFutureDate());
console.log("Чи високосний рік?", myDate.isLeapYear());
console.log("Наступна дата:", myDate.getNextDate().toLocaleDateString());
