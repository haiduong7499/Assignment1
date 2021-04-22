import React, {createContext, useEffect, useState} from 'react';
import {GetProduct} from '../../data/rest_service.js';

export const ProductContext = createContext({});

const ProductContextProvider = ({children}) => {
    const [productItems, setProductItems] = useState([]);

    useEffect(() => {
       
    }, []);

    return (
        <ProductContext.Provider values={{
            productItems
        }}>
            {children}
        </ProductContext.Provider>
        
    );
};

export default ProductContextProvider;