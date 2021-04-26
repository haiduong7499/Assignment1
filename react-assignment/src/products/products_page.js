import React, { useState, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import { TrashFill } from 'react-bootstrap-icons'
import { Link } from 'react-router-dom';
import { fetchProductData, DeleteProduct } from '../service/product.js'

const Product = () => {
    const [productItems, setProduct] = useState([]);

    const fetchData = () => {
        (async () => {
            const products = await fetchProductData();
            setProduct(products)
        })();
    }

    const handleDelete = async (id) => {
        const result = await DeleteProduct(id);
        if (result) {
            fetchData();
        }
    };

    useEffect(() => {
        fetchData();
    }, []);

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
                                <td>{product.rate}</td>
                                <td>
                                    <Button color="danger" className="mr-2" onClick={() => handleDelete(product.productId)}>
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