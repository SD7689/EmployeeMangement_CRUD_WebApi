import React, {Component} from 'react';
import {Modal, Button, Row, Col, Form} from 'react-bootstrap';
import axios from 'axios'

import Snackbar from '@material-ui/core/SnackBar';
import IconButton from '@material-ui/core/IconButton'; 

export class EditEmployee extends Component{

    constructor(props)
    {
        super(props)
        this.state = {
            empId:'',
            fullName: '',
            email:'',
            password:'',
            mobile:'',
            address:'', 
            snackbaropen: false,snackbarmsg:''
    
    };
         this.handleSubmit = this.handleSubmit.bind(this);
    }

    snackbarClose = () =>
    {
        this.setState({snackbaropen:false});
    };

    changeHandler = (event) => {
        this.setState({[event.target.name]: event.target.value})
    }

    handleSubmit = event =>{
        event.preventDefault()
        console.log(this.state)
        axios.put('https://localhost:44369/api/Employee/UpdateEmployee', this.state)
        .then(response => {
            console.log(response)
            this.setState({snackbaropen:true, snackbarmsg:'result'});
        })
        .catch(error => {
            console.log(error)
            this.setState({snackbaropen:true, snackbarmsg:'failed'})
        })
    }

    render()
    {
        const {empId,fullName, email, password,mobile,address} = this.state 
        return(
            <div className="container">
                <Snackbar 
                anchorOrigin={{vertical:'bottom',horizontal:'bottom'}}
                open = {this.state.snackbaropen}
                autoHideDuration = {3000}
                onClose={this.snackbarClose}
                message={<span id="message-id">{this.state.snackbarmsg}</span>}
                action={[
                        <IconButton
                        key="close"
                        arial-label="close"
                        color="inherit"
                        onClick={this.snackbarClose}
                        >
                        x
                        </IconButton>
                       ]}
                />
            <Modal
                {...this.props}
                size="lg"
                aria-labelledby="contained-modal-title-vcenter"
                centered
            >
            <Modal.Header closeButton>
                <Modal.Title id="contained-modal-title-vcenter">
                    Edit Employee
                </Modal.Title>
            </Modal.Header>
                <Modal.Body>
                        <Row>
                            <Col sm={6}>
                                <Form onSubmit={this.handleSubmit}>
                                <Form.Group controlId="empId">
                                        <Form.Label>EmployeeId</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="empId"
                                            value={empId}
                                            onChange={this.changeHandler}
                                            required
                                            disabled
                                            defaultValue = {this.props.empId}
                                            placeholder="EmployeeId"
                                        />
                                </Form.Group>
                                <Form.Group controlId="fullName">
                                    <Form.Label>FullName</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="fullName"
                                            value={fullName}
                                            onChange={this.changeHandler}   
                                            required
                                            defaultValue = {this.props.fullName}
                                            placeholder="FullName"
                                        />
                                </Form.Group>
                                <Form.Group controlId="email">
                                    <Form.Label>Email Id</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="email"
                                            value={email}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.email}
                                            placeholder="Email"
                                        />
                                </Form.Group>
                                <Form.Group controlId="password">
                                    <Form.Label>Password</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="password"
                                            value={password}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.password}
                                            placeholder="Password"
                                        />
                                </Form.Group>
                                <Form.Group controlId="mobile">
                                    <Form.Label>Mobile no.</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="mobile"
                                            value={mobile}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.mobile}
                                            placeholder="Mobile"
                                        />
                                </Form.Group>
                                <Form.Group controlId="address">
                                    <Form.Label>Address</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="address"
                                            value={address}
                                            onChange={this.changeHandler}
                                            required
                                            defaultValue = {this.props.address}
                                            placeholder="Address"
                                        />
                                </Form.Group>
                                <Form.Group>
                                    <Button variant="primary" type="submit">
                                    Edit Employee
                                    </Button>   
                                </Form.Group>
                                </Form>
                            </Col>
                        </Row>
                </Modal.Body>
                <Modal.Footer>
                    <Button onClick={this.props.onHide}>Close</Button>
                </Modal.Footer>
                </Modal>
            </div>
        )
    }
}