import React, { Component } from 'react';
import { Container } from 'reactstrap';
import './navbar/nav-bar';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <nav-bar />
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}
