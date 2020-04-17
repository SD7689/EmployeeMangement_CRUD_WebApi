import React,{Component} from 'react';
import {Container,Button,Col,Row,Form} from 'react-bootstrap';
import { Route, Link, Switch, Redirect } from 'react-router-dom';
import './loginCss.css';
import {axios} from 'axios'

export class Login extends Component {
constructor(props){
    super(props)
    this.state = {
        email:"",
        password: "",
        loginAuthentication : false
    }
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

handleSubmitButton=(event)=>{
    event.preventDefault();
    var data ={
        email: this.state.email,
        password: this.state.password
    }
    axios.post('https://localhost:44369/api/Employee/LoginEmployee', data)
    .then(res=>{
        console.log(res.data);
        if(res.data == data.email && res.data == data.password)
        {
            this.setState({
                loginAuthentication:true
            })
        }
    })
 //   console.log("status", this.state.email, this.state.password);
}

    render() {
        if(this.state.loginAuthentication === true){
            return <Redirect to = '/employee'/>
        }
        return (
            <Container>
            <Row>
            <Col></Col>
            <Col xs={6}>
            <Form action="" name="myForm">
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
                <Form.Check type="checkbox" label="Remember Me" />
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