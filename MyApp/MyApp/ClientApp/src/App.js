import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Switch} from "react-router-dom";
import { Home } from '../src/components/Home/Home'
import { About } from '../src/components/About/about.'
import { Training } from '../src/components/Training/training'

import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <React.Fragment>
          <Router>
            <switch>
                <Route exact path="/" component={Home}/>
                <Route path="/about" component={About}/>
                <Route path="/Training" component={Training}/>
                {/*<Route component={NoMatch}/>*/}
            </switch>
          </Router>
      </React.Fragment>
    );
  }
}
