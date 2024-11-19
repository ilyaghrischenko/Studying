export default function Pet({petInfo}) {
    const {name, age, breed} = petInfo;

    return (
        <div>
            <h1>{name}</h1>
            <p>{age}</p>
            <p>{breed}</p>
        </div>
    );
}