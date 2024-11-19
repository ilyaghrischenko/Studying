import '../styles/Main.css';

import { Container, Row, Col } from 'react-bootstrap';

import { LeftPanel } from './LeftPanel';
import { CentralPanel } from './CentralPanel';
import { RightPanel } from './RightPanel';

const Main = () => {
    return (
        <main>
            <Container>
                <Row className='main-row'>
                    <Col className='left-col'>
                        <LeftPanel />
                    </Col>
                    <Col className='central-col'>
                        <CentralPanel />
                    </Col>
                    <Col className='right-col'>
                        <RightPanel />
                    </Col>
                </Row>
            </Container>
        </main>
    );
};

export { Main };