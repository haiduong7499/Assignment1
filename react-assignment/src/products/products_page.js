import React, { useState, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import { TrashFill } from 'react-bootstrap-icons'
import { host } from '../config.js';
import axios from 'axios';
import { Link } from 'react-router-dom';

const Product = () => {
    const [productItems, setProduct] = useState([]);

    useEffect(() => {
        fetchProductData();
    }, []);

    const fetchProductData = () =>{
        axios.get(host + "/api/Product")
            .then(response => {
                setProduct(response.data);
                console.log(response.data)
            }).catch((error) => {
                console.log('get products err', error);
            });
    }

    const DeleteProduct = (id) => {
        return axios({
            method: "delete",
            url: host + "/api/Product/" + id,
        })
            .then((response) => {
                fetchProductData();
                console.log(response.data)
            })
            .catch((error) => {
                console.log(error.response);
                return null;
            });
    };


    return (
        <>
            <h2 className="text-center p-3">Product</h2>
            <Button color="success" className='mb-2 ml-2'>
                <Link className="text-decoration-none text-white"
                    to='/createproduct_form'>
                    Create Product
                </Link>
            </Button>

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
                                <td>
                                    <Button color="danger" className="mr-2" onClick={async () => await DeleteProduct(product.productId)}>
                                        <TrashFill color="white" size={20} />
                                    </Button>
                                </td>
                            </tr>
                        )
                    }
                </tbody>
            </Table>
        </>
    )
}

export default Product;