import React, { useState, useEffect } from 'react';
import { Table, Button } from 'reactstrap';
import { TrashFill, PenFill } from 'react-bootstrap-icons';
import { Link } from 'react-router-dom';
import { fetchCategoryData, DeleteCategory } from '../service/category';

const Category = () => {
    const [categoryItems, setCategory] = useState([]);

    const fetchData = () => {
        (async () => {
            const category = await fetchCategoryData();
            setCategory(category);
        })();
    }

    const handleDelete = async (id) => {
        const result = await DeleteCategory(id);
        if (result) {
            fetchData();
        }
    }

    useEffect(() => {
        fetchData();
    }, []);
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
                                    <Button color="secondary" className="mr-1">
                                        <Link to={{
                                            pathname: '/createcategory_form/' + category.categoryId,
                                            categoryId: category.categoryId,
                                            category: {
                                                productId: category.productId,
                                                name: category.name,
                                                description: category.description,
                                            }
                                        }}>
                                            <PenFill color="white" size={20} />
                                        </Link>
                                    </Button>
                                </td>
                                <td>
                                    <Button color="danger" className="mr-2" onClick={() => handleDelete(category.categoryId)}>
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