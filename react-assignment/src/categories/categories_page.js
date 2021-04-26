import React, { useState, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import { host } from '../config.js';
import {TrashFill} from 'react-bootstrap-icons';
import axios from 'axios';
import { Link } from 'react-router-dom';
const Category = () => {
    const [categoryItems, setCategory] = useState([]);

    const fetchCategoryData  = () => {
        axios.get(host + "/api/Category")
            .then(response => {
                setCategory(response.data);
            }).catch((error) => {
                console.log('get category err', error);
            });
    }
    useEffect(() => {
        fetchCategoryData();
    }, []);

    const DeleteCategory = (id) => {
        axios.delete(host + "/api/Category/" + id)
            .then(response => {
                fetchCategoryData();
                setCategory(response.data);
            }).catch((error) => {
                console.log('get category err', error);
            });
    }
    return (

        <>
            <h2 className="text-center p-3">Category</h2>
            <Button color="success" className='mb-2 ml-2'>
                <Link className="text-decoration-none text-white"
                    to='/createcategory_form'>
                    Create Category
                </Link>
            </Button>

            <Table dark>
                <thead>
                    <tr>
                        <th>Id Category</th>
                        <th>Name Category</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        categoryItems && categoryItems.map(category =>
                            <tr key={category.categoryId}>
                                <td>{category.categoryId}</td>
                                <td>{category.name}</td>
                                <td>{category.description}</td>
                                <td>
                                    <Button color="danger" className="mr-2" onClick={() => DeleteCategory(category.categoryId)}>
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

export default Category;