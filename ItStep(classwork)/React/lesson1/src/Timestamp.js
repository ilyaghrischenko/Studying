export default function Timestamp() {
    let time = new Date().toTimeString();
    console.log(time);

    return (
        <p>Current time: {time}</p>
    );
}