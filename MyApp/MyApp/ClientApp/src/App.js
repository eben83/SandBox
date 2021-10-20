import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Switch} from "react-router-dom";
import { Home } from '../src/components/Home/Home'
import { About } from '../src/components/About/about'
import { Training } from '../src/components/Training/training'
import Projects  from '../src/components/Projects/Projects'
import ContactMe from '../src/components/ContactMe/contactaMe'
import { Layout } from "./components/Layout";
import {Navigation} from "./components/navbar/Navigation";

import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <React.Fragment>
          <Layout>
              <Router>
                <div>
                    <Route exact path="/" component={Home}/>
                    <Navigation />
                    <Route path="/About" component={About}/>
                    <Route path="/Training" component={Training}/>
                    <Route path="/Projects" component={Projects}/>
                    <Route path="/contactMe" component={ContactMe}/>
                </div>
              </Router>
          </Layout>
      </React.Fragment>
    );
  }
}
