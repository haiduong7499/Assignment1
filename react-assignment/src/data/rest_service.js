import axios from 'axios';

const basehost = 'https://localhost:44303';


export const GetProduct = () => {
    return axios.get(basehost + "/api/Product")
    .then(response => response.data)
    .catch((error) => {
        console.log(error.response);
        return [];
    });
};


