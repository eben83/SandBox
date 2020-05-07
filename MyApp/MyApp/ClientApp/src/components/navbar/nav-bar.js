import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavBar extends Component {
    static displayName = NavBar.name;
    
    render () {
        return (
            <container>
                        <nav className="navbar navbar-expand-sm bg-dark navbar-dark sticky-top">
                            <NavbarBrand tag={Link} to="/">Eben Burger</NavbarBrand>

                            <ul className="navbar-nav sticky-top">
                                <li className="nav-item">
                                    <a className="nav-link" href="../About/about.js">Link 1</a>
                                </li>
                                
                                <li className="nav-item">
                                    <a className="nav-link" href="#">Link 2</a>
                                </li>

                                <li className="nav-item dropdown">
                                    <a className="nav-link dropdown-toggle" href="#" id="navbardrop"
                                       data-toggle="dropdown">
                                        Dropdown link
                                    </a>
                                    <div className="dropdown-menu">
                                        <a className="dropdown-item" href="#">Link 1</a>
                                        <a className="dropdown-item" href="#">Link 2</a>
                                        <a className="dropdown-item" href="#">Link 3</a>
                                    </div>
                                </li>
                            </ul>
                        </nav>
            </container>
        );
    }
}
