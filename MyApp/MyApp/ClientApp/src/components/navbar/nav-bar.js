import React, { useState } from 'react';
import './nav-bar.css';

const Nav = (props) => {

    return (
        <div className="navbar navbar-expand bg-light navbar-light">
            <ul className="navbar-nav">
                <li className="navbar-item active">
                    <a className="nav-link">Link</a>
                </li>
            </ul>
        </div>
    );
}

export default Nav;
