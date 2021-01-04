import React, { } from 'react';
import Header from "./header/header";

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
