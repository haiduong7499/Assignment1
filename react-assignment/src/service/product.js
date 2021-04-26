import { host } from '../config.js';
import axios from 'axios';


export const fetchProductData = async () => {
    const {data} = await axios.get(host + "/api/Product");
    return data;
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