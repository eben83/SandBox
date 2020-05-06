import React, { Component } from 'react';
import ReactDOM from "react-dom";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import "./Home.css";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <section className="text-center home-image text-white-50">
          <h1>Welcome to my Portfolio</h1>
          <h1>I'm A junior Trainee Developer</h1>
          <a className="btn btn-dark btn-lg" href="../About/about.js">Click Me</a>
      </section>
    );
  }
}
