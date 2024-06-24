//task 1
// function compare(x, y) {
//     if (x == y) return 0;
//     else if (x > y) return 1;
//     else return -1;
// }

// console.log(compare(1, 2));

//task 2
// function factorial(num) {
//     if (num == 1) return 1;
//     else return num * factorial(num - 1);
// }

// console.log(factorial(3));

//task 3
// function getNumber(first, second, third) {
//     return +`${first}${second}${third}`;
// }

// console.log(getNumber(1, 2, 3));

//task 4
// function getSquare() {
//     if (arguments.length == 1) return arguments[0] * arguments[0];
//     else if (arguments.length == 2) return arguments[0] * arguments[1];
//     else console.log("Error: getSquare() takes 1 or 2 arguments");
// }

// console.log(getSquare(2, 3));

//task 5, 6
// function isPerfect(num) {
//     let sum = 0;
//     for (let i = 1; i < num; i++) {
//         if (num % i == 0) sum += i;
//     }
//     return sum === num;
// }

// function printPerfectInRange(start, end) {
//     for (let i = start; i <= end; i++) {
//         if (isPerfect(i)) console.log(i);
//     }
// }

// printPerfectInRange(1, 100);

//task 7
// function printTime(hour, minute = 0, second = 0) {
//     console.log(`${(hour.toString().length === 1) ? "0" + hour : hour}:${(minute.toString().length === 1) ? "0" + minute : minute}:${(second.toString().length === 1) ? "0" + second : second}`);
// }

// printTime(2, 21);

//task 8
// function toSeconds(hour, minute, second) {
//     return (hour * 3600) + (minute * 60) + second;
// }

// console.log(toSeconds(1, 50, 0));

//task 9
// function toTime(seconds) {
//     let hours = Math.floor(seconds / 3600);
//     let minutes = Math.floor((seconds % 3600) / 60);
//     let sec = Math.floor(seconds % 60);
//     return `${(hours.toString().length === 1) ? "0" + hours : hours}:${(minutes.toString().length === 1) ? "0" + minutes : minutes}:${(sec.toString().length === 1) ? "0" + sec : sec}`;
// }

// console.log(toTime(3600));

//task 10
// function dateToSeconds(year, month, day, hours, minutes, seconds) {
//     const date = new Date(year, month - 1, day, hours, minutes, seconds);
//     return Math.floor(date.getTime() / 1000);
// }

// function secondsToTimeString(totalSeconds) {
//     const hours = Math.floor(totalSeconds / 3600);
//     totalSeconds %= 3600;
//     const minutes = Math.floor(totalSeconds / 60);
//     const seconds = totalSeconds % 60;

//     return `${hours}:${String(minutes).padStart(2, '0')}:${String(seconds).padStart(2, '0')}`;
// }

// function dateDifference(year1, month1, day1, hours1, minutes1, seconds1, year2, month2, day2, hours2, minutes2, seconds2) {
//     const sec1 = dateToSeconds(year1, month1, day1, hours1, minutes1, seconds1);
//     const sec2 = dateToSeconds(year2, month2, day2, hours2, minutes2, seconds2);
    
//     const diffInSeconds = Math.abs(sec1 - sec2);
    
//     return secondsToTimeString(diffInSeconds);
// }

// console.log(dateDifference(2023, 5, 15, 12, 30, 0, 2023, 5, 16, 14, 45, 30));
