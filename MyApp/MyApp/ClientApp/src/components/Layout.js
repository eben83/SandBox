import React, { Component } from 'react';
import {Container, Nav} from 'reactstrap';
import './navbar/nav-bar';
import { Home } from "./Home/Home";
import { NavBar } from "./navbar/nav-bar";
import About from "./About/about";
import Training from "./Training/training";

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <Home />
        <NavBar />
        <About />
        <Training />
        {/*<Container>*/}
          {/*{this.props.children}*/}
        {/*</Container>*/}
      </div>
    );
  }
}
