import {Row, Col, Alert} from 'react-bootstrap';

const NotFound = () => {
    return (
        <Row>
            <Col>
                <h2>Сторінку не знайдено</h2>
                <Alert variant="danger" className = "mt-3 mb-3">
                    Сторінку, яку ви намагаєтеся відкрити, не знайдено. 
                </Alert>
                
            </Col>
        </Row>
    )
}
export {NotFound}