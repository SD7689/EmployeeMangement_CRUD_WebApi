import React,{Component} from 'react';
import {Container,Button,Col,Row,Form} from 'react-bootstrap';
import './loginCss.css';

export class Login extends Component {

    render() {
        return (
            <Container>
            <Row>
            <Col></Col>
            <Col xs={6}>
            <Form>
            <h3 className = "m-4 d-flex justify-content-center">
            Login Page
            </h3>
            <Form.Group controlId="validationCustom01"></Form.Group>

            <Form.Group controlId="formBasicEmail">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" />
                <Form.Text className="text-muted">
                We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>

            <Form.Group controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" />
            </Form.Group>

            <Form.Group controlId="formBasicCheckbox">
                <Form.Check type="checkbox" label="Check me out" />
            </Form.Group>
            
            <Button variant="primary" type="submit">
                Submit
            </Button>
                <p className="forgot-password text-right">
                    Forgot <a href="#">password?</a>
                </p>
            </Form>
            </Col>
            <Col></Col>
            </Row>
            </Container>
        );
    }
}