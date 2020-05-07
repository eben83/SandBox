import React, { Component } from 'react';
import ReactDOM from "react-dom";
import {BrowserRouter, Link, Route, Switch} from "react-router-dom";
import "./Home.css";
import About from "../About/about";
import {NavLink} from "reactstrap";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <section className="text-center home-image text-white-50">
          <h1>Welcome to my Portfolio</h1>
          <h1>I'm A junior Trainee Developer</h1>
      </section>
    );
  }
}
