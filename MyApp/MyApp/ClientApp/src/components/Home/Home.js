import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <section className="p-5 text-center">
        <h1>Welcome to my Portfolio</h1>
        <h1>I'm A junior Trainee Developer</h1>
      </section>
    );
  }
}
