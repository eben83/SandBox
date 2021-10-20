import React from 'react';
import { Nav, Navbar } from "react-bootstrap";


export const Navigation = () => (
    <Navbar expand="lg">
        <Navbar.Brand href="/">Eben Burger</Navbar.Brand>
        <Navbar.Collapse>
            <Nav className="ml-auto">
                <Nav.Item><Nav.Link href="/">Home</Nav.Link></Nav.Item>
                <Nav.Item><Nav.Link href="/about">About</Nav.Link></Nav.Item>
                <Nav.Item><Nav.Link href="/training">Training</Nav.Link></Nav.Item>
                <Nav.Item><Nav.Link href="/Projects">Projects</Nav.Link></Nav.Item>
                <Nav.Item><Nav.Link href="/ContactMe">Contact</Nav.Link></Nav.Item>
            </Nav>
        </Navbar.Collapse>
    </Navbar>
    
)