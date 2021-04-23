import React, { useState, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import {host} from '../config.js';
import axios from 'axios';
import { Link } from 'react-router-dom';

const Product = () => {
    const [productItems, setProduct] = useState([]);

    useEffect(() => {
        axios.get(host +"/api/Product") 
        .then(response => {
            setProduct(response.data);
        }).catch((error) => {
            console.log('get products err', error);
        });
    }, []);

    return (
        
        <>
            <h2 className="text-center p-3">Product</h2>
            <Link to='/createproduct_form'><Button color="success" className='mb-2 ml-2'>Create Product</Button></Link>

            <Table dark>
                <thead>
                    <tr>
                        <th>Id Product</th>
                        <th>Name Product</th>
                        <th>Description</th>
                        <th>Price</th>
                        <th>Product Image</th>
                        <th>Rate</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        productItems && productItems.map(product =>
                            <tr key={product.productId}>
                                <td>{product.productId}</td>
                                <td>{product.nameProduct}</td>
                                <td>{product.description}</td>
                                <td>{product.price}$</td>
                                <td>
                                    <img src={product.productImg} alt={product.nameProduct} width="150px" height="150px"></img>
                                </td>
                                <td>{product.rated}</td>
                            </tr>
                        )
                    }
                </tbody>
            </Table>
        </>
    )
}

export default Product;