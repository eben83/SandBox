import React, { useState } from 'react';
import './nav-bar.css';

const NavBar = (props) => {

    return (
        <nav className="navbar navbar-expand bg-dark navbar-dark fixed-top">
                <a className="navbar-brand">Eben Burger</a>
            
            <ul className="navbar-nav">
                
                <li className="nav-item">
                    <a className="nav-link" href="#">Home</a>
                </li>
                
                <li className="nav-item">
                    <a className="nav-link" href="#">About Me</a>
                </li>
                
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown">
                        Education
                    </a>
                    
                    <div class="dropdown-menu">
                        <a class="dropdown-item" href="#">Link 1</a>
                        <a class="dropdown-item" href="#">Link 2</a>
                        <a class="dropdown-item" href="#">Link 3</a>
                    </div>
                </li>
            </ul>
        </nav>
    );
}

export default NavBar;
