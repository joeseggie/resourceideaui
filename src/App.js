import React from 'react';
import './App.css';
import Home from './components/home/Home';
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Nav from './components/common/nav/Nav';
import Reset_password from "./components/reset_password/Reset_password";
import Login from "./components/login/Login";
import Dashboard from "./components/dashboard/Dashboard";
import Admin from './components/admin/Admin';
import ProfileDetail from './components/profile/ProfileDetail';

const App = () => {
  return (
    <Router>
      <div className="App">
        <Nav />
        <Switch>
          <Route path='/' exact component={Home} />
<Route path='/login' component={Login} />
          <Route path='/dashboard' component={Dashboard} />
          <Route path='/admin' component={Admin} />
          <Route path='/profile' component={ProfileDetail} />
        </Switch>
      </div>
    </Router>
  );
}

export default App;
