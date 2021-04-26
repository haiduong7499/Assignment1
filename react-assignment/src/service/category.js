import { host } from '../config.js';
import axios from 'axios';


export const fetchCategoryData = async () => {
    const { data } = await axios.get(host + "/api/Category");
    return data;
}

export const DeleteCategory = (id) => {
    return axios({
        method: "delete",
        url: host + "/api/Category/" + id,
    })
        .then(({ data }) => {
            console.log(data);
            return true;
        })
        .catch((error) => {
            console.log(error.response);
            return null;
        });
};