import React, { Component } from 'react';
import Header from "./header/header";

/*export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        {this.props.children}
      </div>
    );
  }
}*/

const Layout = (props) => {
  return (
      <>
          <Header/>
        <div>
            {props.children}
        </div>
      </>
  )
}
export default Layout;
