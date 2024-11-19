export default function PersonalPage({pib, phone, email, address, workExperience, photo}) {
  return (
    <div>
      <h1>{pib}</h1>
      <h2>{phone}</h2>
      <p>{email}</p>
      <p>{address}</p>
      <p>{workExperience}</p>
      <img src={photo} alt="photo" />
    </div>
  );
}