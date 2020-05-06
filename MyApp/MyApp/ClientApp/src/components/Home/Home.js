import React, { Component } from 'react';
import "./Home.css";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <section className="text-center home-image text-white-50">
          <h1>Welcome to my Portfolio</h1>
          <h1>I'm A junior Trainee Developer</h1>
          <a className="btn btn-primary btn-dark">Click me</a>
      </section>
    );
  }
}
