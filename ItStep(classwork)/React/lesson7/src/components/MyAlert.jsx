import {Row, Col, Alert} from 'react-bootstrap';

const MyAlert = ({head, children, type = 'danger'}) => {
    return (
        <Row>
            <Col>
                <Alert 
                    variant = {type} 
                    className="mt-3 mb-3 p-3"
                >
                    <Alert.Heading>{head}</Alert.Heading>
                    <hr/>
                    <p> {children} </p>
                </Alert>
            </Col>
        </Row>

    )
}

export {MyAlert}