import React,{Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button, ButtonToolbar} from 'react-bootstrap';
import {AddEmployee} from './AddEmployee';
import {EditEmployee} from './EditEmployee';

export class Employee extends Component 
{

    constructor(props)
    {
        super(props);
        this.state={emps:[], addModalShow : false, editModalShow : false}
    }

    componentDidMount(){
        this.refreshList();
    }

    refreshList()
    {
        fetch('https://localhost:44369/api/Employee/GetAllEmployee')
        .then(Response=> Response.json())
        .then(data => 
            {
                this.setState({emps:data});
            }
        );
    }
//state or property get changed will refresh the list
    componentDidUpdate()
    {
        this.refreshList();
    }

    deleteEmp(empid)
    {
        if(window.confirm('Are you sure?'))
        {
            fetch('https://localhost:44369/api/Employee/DeleteEmployee/' +empid,
            {
                method:'DELETE',
                header:
                {
                    'Accept':'application/json',
                    'Content-Type':'application/json'
                }
            })
        }
    }
    render(){
        const {emps , empid, empname, empEmail, empPass, empMob, empAdd} = this.state;
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
                        <th>Option</th>
                       {/* <th></th> */}
                    </tr>
                </thead>
                <tbody>
                    {emps.map(emp=>
                        <tr key={emp.EmployeeId}>
                        <td> {emp.EmployeeId}</td>
                        <td> {emp.FullName}</td>
                        <td> {emp.Email}</td>
                        <td> {emp.Password}</td>
                        <td> {emp.Mobile}</td>
                        <td> {emp.Address}</td>
                        <td>
                            <ButtonToolbar>
                        <Button
                            className="mr-2" variant="primary"
                            onClick={()=> this.setState({editModalShow:true,empid:emps.EmployeeId, empname:emps.FullName, empEmail:emps.Email, empPass:emps.Password, empMob:emps.Mobile, empAdd:emps.Address})}
                        >Edit
                        </Button>
                        <Button
                            className="mr-2" variant="danger"
                            onClick={()=> this.deleteEmp(emp.empid)}
                        >
                        Delete
                        </Button>
                        <EditEmployee
                            show = {this.state.editModalShow}
                            onHide={editModalClose}
                            empid = {empid}
                            empname = {empname}
                            empEmail = {empEmail}
                            empPass = {empPass}
                            empMob = {empMob}
                            empAdd = {empAdd}
                        />
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