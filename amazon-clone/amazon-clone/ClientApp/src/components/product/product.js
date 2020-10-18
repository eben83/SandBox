import React from 'react'
import StarRateIcon from '@material-ui/icons/StarRate';

import './product.css'

const Product = () => {
    return (
        <>
            <div className='product'>
                <div className='product__info'>
                    <p>The Lean startup</p>
                    <p className="product__price">
                        <small>R</small>
                        <strong>19,99</strong>
                    </p>
                    <div className='product__rating'>
                        <p><StarRateIcon/></p>
                    </div>
                </div>
                <img src='https://images-na.ssl-images-amazon.com/images/I/51T-sMqSMiL._SX329_BO1,204,203,200_.jpg' 
                     alt='the lean startup' 
                />
                <button> Add to basket</button>
            </div>
        </>
    )
}
export default Product;