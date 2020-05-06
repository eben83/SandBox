import React, { Component } from 'react';
import {Container, Nav} from 'reactstrap';
import './navbar/nav-bar';
import NavBar from "./navbar/nav-bar";
import {Home} from "./Home/Home";

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <NavBar />
        <Home />
        {/*<Container>*/}
        {/*  {this.props.children}*/}
        {/*</Container>*/}
      </div>
    );
  }
}
