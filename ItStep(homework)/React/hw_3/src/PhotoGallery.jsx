import "./PhotoGallery.css";
import Photo from "./Photo";

export default function PhotoGallery({ photos }) {
    return (
        <div className="photo-gallery">
            <ul>
                {photos.map((photo, index) => (
                    <li key={index}>
                        <Photo path={photo.path} description={photo.description} />
                    </li>
                ))}
            </ul>
        </div>
    );
}
