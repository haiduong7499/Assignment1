import { React, useState, useEffect } from 'react';
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';
import { useParams } from 'react-router-dom';
import axios from 'axios';
import { host } from '../config.js'
import { useFormik } from 'formik';

const CreateCategory = (props) => {
    const { id } = useParams();
    console.log(id);
    const [categoryItems, setCategory] = useState(null);

    useEffect(() => {
        axios.get(host + "/api/Category")
            .then(response => {
                setCategory(response.data);
            }).catch((error) => {
                console.log('get category err', error);
            });
    }, []);

    const formik = useFormik({
        initialValues: {
            categoryId: '',
            name: '',
            description: '',
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

            if (id) {
                axios.put(host + "/api/Category/" + id, formData)
                    .then(response => {
                        setCategory(response.data);
                    }).catch((error) => {
                        console.log('put Category err', error);
                    });
            }
            else {
                axios.post(host + "/api/Category", formData)
                    .then(response => {
                        setCategory(response.data);
                    }).catch((error) => {
                        console.log('post Category err', error);
                    });
            }
            action.setSubmitting(false);
        }
    })

    return (
        <>
            <Form onSubmit={formik.handleSubmit}>
                <FormGroup>
                    <Label>Id Category</Label>
                    <Input value={formik.values.categoryId} onChange={formik.handleChange}
                        name="categoryId" type='number' />
                </FormGroup>
                <FormGroup>
                    <Label for="description">Name Category</Label>
                    <Input value={formik.values.name} onChange={formik.handleChange}
                        name="name" id="name" />
                </FormGroup>
                <FormGroup>
                    <Label for="price">Description</Label>
                    <Input value={formik.values.description} onChange={formik.handleChange}
                        name="description" id="description" />
                </FormGroup>
                <Button disabled={formik.isSubmitting} type='submit' color="success">Submit</Button>
            </Form>
        </>
    );
}

export default CreateCategory;