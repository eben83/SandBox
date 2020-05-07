import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Switch} from "react-router-dom";
import { Home } from '../src/components/Home/Home'
import { About } from '../src/components/About/about'
import { Training } from '../src/components/Training/training'
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
                <switch>
                    <Route exact path="/" component={Home}/>
                    <Navigation />
                    <Route path="/about" component={About}/>
                    <Route path="/Training" component={Training}/>
                </switch>
              </Router>
          </Layout>
      </React.Fragment>
    );
  }
}
