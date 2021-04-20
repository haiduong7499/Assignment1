import React, { useState } from 'react';
import {
    Collapse,
    Navbar,
    NavbarToggler,
    Nav,
    NavItem,
    Button,
    NavLink
} from 'reactstrap';
import { Link } from 'react-router-dom';
const NavbarComponent = (props) => {
    const [isOpen, setIsOpen] = useState(false);

    const toggle = () => setIsOpen(!isOpen);
    return (
        <div>
            <Navbar color="#5F9EA0" light expand="md">
                <img src="./logo.png"></img>
                <NavbarToggler onClick={toggle} />
                <Collapse isOpen={isOpen} navbar>
                    <Nav className="mr-auto" navbar>
                        <NavItem >
                            <NavLink><Link className="text-decoration-none" to="/categories">
                                Category
                            </Link>
                        </NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink><Link className="text-decoration-none" to="/products_page">
                                Products
                            </Link></NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink><Link className="text-decoration-none" to="/users">
                                Users
                            </Link></NavLink>
                        </NavItem>
                    </Nav>
                </Collapse>
                <Button color="danger" className="float-right">Sign out</Button>
            </Navbar>
        </div>
    );
}

export default NavbarComponent;