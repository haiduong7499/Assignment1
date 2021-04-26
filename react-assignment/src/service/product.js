import { host } from '../config.js';
import axios from 'axios';
import {useState} from 'react'


export const fetchProductData = async () => {
    const {data} = await axios.get(host + "/api/Product");
    return data;
        // .then(response => {
        //     return response.data;
        // }).catch((error) => {
        //     console.log('get products err', error);
        // });
}

export const DeleteProduct = (id) => {
    return axios({
        method: "delete",
        url: host + "/api/Product/" + id,
    })
        .then(({data}) => {
            console.log(data);
            return true;
        })
        .catch((error) => {
            console.log(error.response);
            return null;
        });
};