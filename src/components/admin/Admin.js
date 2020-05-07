import React, { Component } from "react";
import AdminMenu from "./AdminMenu";
import { Route } from "react-router-dom";
import EmployeeDashboard from "./employee/EmployeeDashboard";
import Departments from "./department/Departments";
import Engagements from "./engagement/Engagements";
import ClientIndustries from "./clientIndustry/ClientIndustries";
import JobPosition from "./jobPosition/JobPosition";
import LinesOfService from './linesOfService/LinesOfService';
import EmployeeList from "./employee/EmployeeList";
import AddEmployee from "./employee/AddEmployee";
import ClientDashboard from "./client/ClientDashboard";
import ClientsList from "./client/ClientList";
import AddClient from "./client/AddClient";

class Admin extends Component {
    render() {
        return (
            <div className='container-fluid'>
                <h3> Administration Panel</h3>
                <div className='row'>
                    <div className='col-2'>
                        <AdminMenu />
                    </div>
                    <div className='col-10'>
                        <Route path='/admin/departments' component={Departments} />
                        <Route path='/admin/engagements' component={Engagements} />
                        <Route path='/admin/client-industries' component={ClientIndustries} />
                        <Route path='/admin/job-positions' component={JobPosition} />
                        <Route path='/admin/lines-of-service' component={LinesOfService} />

                        {/* Employee admin components */}
                        <Route exact path='/admin/employees' component={EmployeeDashboard} />
                        <Route path='/admin/employees/list' component={EmployeeList} />
                        <Route path='/admin/employees/add' component={AddEmployee} />

                        {/* Client admin components */}
                        <Route exact path='/admin/clients' component={ClientDashboard} />
                        <Route path='/admin/clients/list' component={ClientsList} />
                        <Route path='/admin/clients/add' component={AddClient} />

                    </div>
                </div>
            </div>
        );
    }
}

export default Admin;