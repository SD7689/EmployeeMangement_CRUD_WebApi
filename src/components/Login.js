import React,{Component} from 'react';
import {Container,Button,Col,Row,Form} from 'react-bootstrap';
import './loginCss.css';

export class Login extends Component {
constructor(props){
    super(props)
    this.state = {
        email:"",
        password: ""
    }
}

handleEmailChange=(event)=>{
    const email=event.target.value;
    this.setState({
        email:email
    })
    console.log("email",this.state.email)
}

handleEmailChange=(event)=>{
    const email=event.target.value;
    this.setState({
        email:email
    })
    console.log("email",this.state.email)
}

handlePasswordChange=(event)=>{
    const password=event.target.value;
    this.setState({
        password:password
    })
    console.log("password",this.state.password)
}

handleSubmitButton=()=>{
    console.log("status", this.state.email, this.state.password);
}



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

            <Form.Group controlId="formBasicEmail">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" onChange={this.handleEmailChange}/>
                <Form.Text className="text-muted">
                We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>

            <Form.Group controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" onChange={this.handlePasswordChange}/>
            </Form.Group>

            <Form.Group controlId="formBasicCheckbox">
                <Form.Check type="checkbox" label="Check me out" />
            </Form.Group>
            
            <Button variant="primary" type="submit" onClick={this.handleSubmitButton} >
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