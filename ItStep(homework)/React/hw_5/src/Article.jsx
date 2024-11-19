import { Row, Col, Card } from 'react-bootstrap';

const Article = ({
    title,
    author,
    content,
    publishingDate,
    fontFamily,
    fontColor,
    fontSize,
    bgColor,
    titleAlign = 'center',
    img = null,
    imgPosition = 'left'
}) => {
    return (
        <Card
            className='overflow-auto'
            style={{
                fontFamily: fontFamily,
                color: fontColor,
                fontSize: fontSize,
                backgroundColor: bgColor,
                padding: '15px'
            }}>
            <Row>
                {img && imgPosition === 'left' && (
                    <Col xs={12} md={4}>
                        <img src={img} alt="img" style={{ width: '100%' }} />
                    </Col>
                )}

                <Col
                    xs={12}
                    md={img ? 8 : 12}
                    style={{
                        display: 'flex',
                        flexDirection: 'column',
                        justifyContent: 'center'
                    }}>
                    <h1 style={{ textAlign: titleAlign }}>{title}</h1>
                    <p>{author}</p>
                    <p style={{
                        whiteSpace: 'normal',
                        wordBreak: 'break-word'
                    }}>
                        {content}
                    </p>
                    <p>{publishingDate}</p>
                </Col>

                {img && imgPosition === 'right' && (
                    <Col xs={12} md={4}>
                        <img src={img} alt="img" style={{ width: '100%' }} />
                    </Col>
                )}
            </Row>
        </Card>
    );
};

export { Article };
