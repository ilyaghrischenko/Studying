import './App.css';

import 'bootstrap/dist/css/bootstrap.min.css';
import { Container } from 'react-bootstrap';

import ArticleModel from './ArticleModel';
import { Article } from './Article';
import meImg from './me.jfif';

function App() {
  const article = new ArticleModel('Title1', 'Author1', 'Content1', '2020-01-01');

  return (
    <Container>
      <Article
        {...article}
        fontFamily={'Times New Roman'}
        fontColor={'red'}
        fontSize={'30px'}
        bgColor={'black'}
        img={meImg}
        imgPosition={'left'}
        titleAlign={'center'} />
      <hr/>

      <Article
        {...article}
        fontFamily={'Times New Roman'}
        fontColor={'blue'}
        fontSize={'25px'}
        bgColor={'white'}
        img={meImg}
        imgPosition={'right'}
        titleAlign={'left'} />
    </Container>
  );
}

export default App;
