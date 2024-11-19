import "./Photo.css";

export default function Photo({ path, description }) {
    return (
        <div className="photo">
            <img src={path} />
            <p className="photo-description">{description}</p>
        </div>
    );
}
