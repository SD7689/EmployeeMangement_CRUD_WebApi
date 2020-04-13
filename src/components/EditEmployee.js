import React, {Component} from 'react';
import {Modal, Button, Row, Col, Form} from 'react-bootstrap';

import Snackbar from '@material-ui/core/SnackBar';
import IconButton from '@material-ui/core/IconButton'; 

export class EditEmployee extends Component{
    constructor(props)
    {
        super(props);
        this.state = {snackbaropen: false,snackbarmsg:''};
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    snackbarClose = (event) =>
    {
        this.setState({snackbaropen:false});
    };

    handleSubmit(event)
    {
        event.preventDefault();
        fetch('https://localhost:44369//api/Employee/UpdateEmployee',
        {
            method:'PUT',
            headers:
            {
                'Accept': 'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify
            ({
                EmployeeId:event.target.EmployeeId.value,
                FullName: event.target.FullName.value,
                Email: event.target.Email.value,
                Password:event.target.Password.value,
                Mobile:event.target.Mobile.value,
                Address:event.target.Email.value
            })
        })
        .then(res=> res.json())
        .then((result)=>
        {
           // alert(result);
           this.setState({snackbaropen:true, snackbarmsg:result});
        },
        (error)=>
        {
           this.setState({snackbaropen:true, snackbarmsg:'failed'})
            //alert('Failed')
        }
        )
    }
    render()
    {
        return(
            <div className="container">
                <Snackbar 
                anchorOrigin={{vertical:'center',horizontal:'center'}}
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
                                <Form.Group controlId="EmployeeId">
                                        <Form.Label>EmployeeId</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="EmployeeId"
                                            required
                                            disabled
                                            defaultValue = {this.props.empid}
                                            placeholder="EmployeeId"
                                        />
                                </Form.Group>
                                <Form.Group controlId="FullName">
                                    <Form.Label>FullName</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="FullName"
                                            required
                                            defaultValue = {this.props.empname}
                                            placeholder="FullName"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Email">
                                    <Form.Label>Email Id</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Email"
                                            required
                                            defaultValue = {this.props.empEmail}
                                            placeholder="Email"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Password">
                                    <Form.Label>Password</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Password"
                                            required
                                            defaultValue = {this.props.empPass}
                                            placeholder="Password"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Mobile">
                                    <Form.Label>Mobile no.</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Mobile"
                                            required
                                            defaultValue = {this.props.empMob}
                                            placeholder="Mobile"
                                        />
                                </Form.Group>
                                <Form.Group controlId="Address">
                                    <Form.Label>Address</Form.Label>
                                        <Form.Control
                                            type="text"
                                            name="Address"
                                            required
                                            defaultValue = {this.props.empAdd}
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