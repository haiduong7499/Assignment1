import axios from 'axios';

const basehost = 'https://haiduongassignment.azurewebsites.net';


export const GetProduct = () => {
    return axios.get(basehost + '/api/Product')
    .then(response => console.log(response.data))
    .catch((error) => {
        console.log(error.response);
        return [];
    });
};

