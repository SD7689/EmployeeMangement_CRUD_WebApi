import React,{Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button, ButtonToolbar} from 'react-bootstrap';
import {AddEmployee} from './AddEmployee';
import {EditEmployee} from './EditEmployee';
import axios from 'axios';

export class Employee extends Component 
{
    constructor(props)
    {
        super(props);
        this.state={emps:[],empId:'', addModalShow : false, editModalShow : false}
    }

    componentDidMount(){
        this.refreshList();
    }

    refreshList()
    {
        axios.get('https://localhost:44369/api/Employee/GetAllEmployee')
        .then(response=> {
            const emps = response.data;
            this.setState({
                emps : emps
            })
            console.log(this.state.emps);
            })
    }

    //state or property get changed will refresh the list
    componentDidUpdate()
    {
        this.refreshList();
    }

    handleChange = event =>{
        this.setState({empId: event.target.value});
    }

    deleteEmp(empId) {
      //  event.preventDefault();
        if(window.confirm('Are you sure?'))
        {
        axios.delete('https://localhost:44369/api/Employee/DeleteEmployee/',+empId)
        .then(response => 
            {
            const empId = response.data;
            this.setState({
                empId : empId
            })
            console.log(this.state.empId);
            //console.log(res.data);
        })
        }
    }

    render(){
        const {emps , empId, fullName, email, password, mobile, address} = this.state;
        let addModalClose =() => this.setState({addModalShow:false});
        let editModalClose =() => this.setState({editModalShow:false});
        return(
            <div>
            <Table className="mt-4" striped bordered hover size="sm">
                <thead>
                    <tr>
                        <th>EmployeeId</th>
                        <th>FullName</th>
                        <th>Email</th>
                        <th>Password</th> 
                        <th>Mobile</th>
                        <th>Address</th>
                        <th>Edit</th>
                        <th>Delete</th>
                    
                    </tr>
                </thead>
                <tbody>
                    {emps.map(emp=>
                        <tr key={emp.empId}>
                        <td> {emp.empId}</td> 
                        <td> {emp.fullName}</td>
                        <td> {emp.email}</td>
                        <td> {emp.password}</td>
                        <td> {emp.mobile}</td>
                        <td> {emp.address}</td>
                        <td>
                            <ButtonToolbar>
                            <Button
                                className="mr-2" variant="primary"
                                onClick={()=> 
                                    this.setState(
                                        {
                                            editModalShow:true,
                                            empId:emps.EmployeeId,
                                            fullName:emps.FullName,
                                            email:emps.Email,
                                            password:emps.Password,
                                            mobile:emps.Mobile,
                                            address:emps.Address
                                        })}
                            >Edit
                            </Button>
                            <EditEmployee
                                empId = {empId}
                                fullName = {fullName}
                                email = {email}
                                password = {password}
                                mobile = {mobile}
                                address = {address}
                                show = {this.state.editModalShow}
                                onHide={editModalClose}
                            />
                            </ButtonToolbar>
                        </td>
                        <td>
                            <ButtonToolbar>
                            <Button
                            className="mr-2" variant="danger" 
                            onChange={this.handleChange}
                            onClick={()=> this.deleteEmp(emps.empid)}
                            >
                            Delete
                            </Button>
                            </ButtonToolbar>
                        </td>
                        </tr>
                        )}
                </tbody>
            </Table>
            <ButtonToolbar>
                <Button variant="primary" onClick={()=> this.setState({addModalShow:true})}>
                Add Employee
                </Button>
                <AddEmployee
                    show={this.state.addModalShow}
                    onHide={addModalClose}
                />
            </ButtonToolbar>
            </div>
        )
    }
}