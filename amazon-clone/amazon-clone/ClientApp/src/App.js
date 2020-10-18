import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './pages/home/home';
import Checkout from './pages/checkout/checkout' 

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <switch>
          <Route exact path='/' component={Home} />
          <Route exact path='/checkout' component={Checkout} />
        </switch>
      </Layout>
    );
  }
}
