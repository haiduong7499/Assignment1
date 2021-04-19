import React, { useState } from 'react';
import {
    Collapse,
    Navbar,
    NavbarToggler,
    Nav,
    NavItem,
    NavLink,
    Button
} from 'reactstrap';

const NavbarComponent = (props) => {
    const [isOpen, setIsOpen] = useState(false);

    const toggle = () => setIsOpen(!isOpen);

    return (
        <div>
            <Navbar color="light" light expand="md">
                <img src="./logo.png"></img>
                <NavbarToggler onClick={toggle} />
                <Collapse isOpen={isOpen} navbar>
                    <Nav className="mr-auto" navbar>
                        <NavItem>
                            <NavLink href="#">Category</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink href="#">Product</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink href="#">User</NavLink>
                        </NavItem>
                    </Nav>
                </Collapse>
                <Button color="danger" className="float-right">Sign out</Button>
            </Navbar>
        </div>
    );
}

export default NavbarComponent;