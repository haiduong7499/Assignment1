import { React, useState, useEffect } from 'react';
import { Button, Form, FormGroup, Label, Input, InputGroup } from 'reactstrap';
import axios from 'axios';
import { host } from '../config.js'
import { useFormik } from 'formik';

const CreateProduct = (props) => {
    const [categoryItems, setCategoryItem] = useState([]);
    const [product, setProduct] = useState(null);

    useEffect(() => {
        if (categoryItems.length === 0) {
            axios.get(host + "/api/Category")
                .then(response => {
                    setCategoryItem(response.data);
                }).catch((error) => {
                    console.log('get category err', error);
                });
        }

        if (product) {
            alert('successful');
        }

    }, [product]);

    const formik = useFormik({
        initialValues: {
            nameProduct: '',
            description: '',
            price: 0,
            categoryId: '',
            ProductImg: null,
        },
        onSubmit: (values, action) => {
            values = {
                ...values,
                categoryId: Number(values.categoryId),
            };

            action.setSubmitting(true);
            console.log(values);

            var formData = new FormData();

            Object.keys(values).forEach(key => {
                formData.append(key, values[key])
            });

            axios.post(host + "/api/Product", formData)
                .then(response => {
                    setProduct(response.data);
                    console.log(response.data);
                }).catch((error) => {
                    console.log('post products err', error);
                });
            action.setSubmitting(false);
        }
    })

    return (
        <>
            <Form onSubmit={formik.handleSubmit}>
                <FormGroup>
                    <Label>Name Product</Label>
                    <Input value={formik.values.nameProduct} onChange={formik.handleChange}
                        name="nameProduct" />
                </FormGroup>
                <FormGroup>
                    <Label for="description">Description</Label>
                    <Input value={formik.values.description} onChange={formik.handleChange}
                        name="description" id="description" />
                </FormGroup>
                <FormGroup>
                    <Label for="price">Price</Label>
                    <Input value={formik.values.price} onChange={formik.handleChange}
                        name="price" id="price" type='number' />
                </FormGroup>

                <InputGroup>
                    <Label for="exampleSelect">Select</Label>
                    <Input type="select" name="categoryId" value={formik.values.categoryId} onChange={formik.handleChange}>
                        {
                            categoryItems && categoryItems.map(category =>
                                <option value={category.categoryId}>{category.name}</option>
                            )}
                    </Input>
                </InputGroup>

                <InputGroup>
                    <input name="ProductImg" type="file" onChange={(event) => {
                        formik.setFieldValue("ProductImg", event.currentTarget.files[0]);
                    }} />
                </InputGroup>
                <Button disabled={formik.isSubmitting} type='submit' color="success">Submit</Button>
            </Form>
        </>
    );
}

export default CreateProduct;