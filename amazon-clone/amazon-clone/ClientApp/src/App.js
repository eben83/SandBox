import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Header from "./components/header/header";
import Home from './pages/home';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
      </Layout>
    );
  }
}
