import React, { useState, useContext, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import { ProductContext } from './model/product.js';
import axios from 'axios';

const Product = () => {
    const [modal, setModal] = useState(false);
    const toggle = () => setModal(!modal);
    const [productItems, setProduct] = useState([]);

    useEffect(() => {
        axios.get("https://localhost:44303/api/Product")
        .then(response => {
            console.log(response.data);
            setProduct(response.data);
        }).catch((error) => {
            console.log('get products err', error);
        });
    }, []);

    return (
        
        <>
            <h2 className="text-center p-3">Product</h2>
            <Button color="success" className='mb-2 ml-2'>Create Product</Button>

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