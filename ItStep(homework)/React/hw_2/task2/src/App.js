import logo from './logo.svg';
import './App.css';
import PersonalPage from './PersonalPage';

function App() {
  return (
    <div>
      <PersonalPage
        pib="Hryshchenko Illia Vladimirovich"
        phone="+380970878346"
        email="ilyahryshchenko@gmail.com"
        address="Kremechuk, Ukraine"
        workExperience="2 years"
        photo="./img/me.jfif" />
        {/* Така ж проблема, не розумію, чого не показує фото */}
    </div>
  );
}

export default App;
