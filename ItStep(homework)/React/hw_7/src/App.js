import 'bootstrap/dist/css/bootstrap.min.css';

import { Container } from 'react-bootstrap';

import { Cinema } from './Cinema';
import Movie from './Movie';
import filmImg from './film.jpg';

import { Blog } from './Blog';
import BlogModel from './BlogModel';

import { Country } from './Country';
import CountryModel from './CountryModel';
import { City } from './City';
import CityModel from './CityModel';
import NYgerb from './newYorkGerb.jpg';
import LAgerb from './losAngelesGerb.jpg';
import CHgerb from './chicagoGerb.png';

function App() {
  /* TASK 1
  const movie = new Movie(
    'The Matrix',
    'A revolutionary story of the human condition',
    filmImg,
    [
      '12.04.2019 15:00',
      '12.04.2019 16:00',
      '12.04.2019 17:00', 
      '12.04.2019 18:00',
      '12.04.2019 19:00',
      '12.04.2019 20:00',
      '12.04.2019 21:00',
      '12.04.2019 22:00',
      '12.04.2019 23:00'
    ]
  )*/

  /* TASK 2
    const blog = new BlogModel(
      'React',
      'React is a JavaScript library for building user interfaces',
      '12.04.2019 15:00',
      ['React', 'JavaScript', 'UI']
    );*/

  const country = new CountryModel(
    'USA',
    [
      new CityModel(
        'New York',
        'The largest city in the United States',
        NYgerb,
        1000000,
        1000
      ),
      new CityModel(
        'Los Angeles',
        'The largest city in the United States',
        LAgerb,
        1000000,
        1000
      ),
      new CityModel(
        'Chicago',
        'The largest city in the United States',
        CHgerb,
        2000000,
        1000
      )
    ]
  );

  return (
    <Container>
      {/* <Cinema {...movie} /> Task 1 */}
      {/* <Blog {...blog} /> Task 2 */}
      <Country {...country} />
    </Container>
  );
}

export default App;
