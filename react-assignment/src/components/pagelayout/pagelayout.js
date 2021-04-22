import { Container, Col } from 'reactstrap';

export default function PageLayout({ header, content }) {

    return (
        <Container fluid={true}>
            <div className='p-3' style={{ backgroundColor: "#5F9EA0" }}>{header}</div>
            <Col className="p-4" style={{ backgroundColor: "#fafafa" }} xs={12}>
                <div className="bg-white h-100 rounded p-3">{content}</div>
            </Col>
        </Container>
    );

}