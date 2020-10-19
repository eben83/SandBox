import React from 'react'
import StarRateIcon from '@material-ui/icons/StarRate';
import  useStateValue  from '../../StateProvider'

import './product.css'

const Product = ({title, image, alt, price, rating}) => {
    const [{ state }, dispatch] = useStateValue();
    
    const addToBasket = () => {
        dispatch ({
            type: 'ADD_TO_BASKET',
            item: {
                title: title,
                image: image,
                price: price,
                rating: rating,
            }
        })
    }
    
    return (
        <>
            <div className='product'>
                <div className='product__info'>
                    <p>{title}</p>
                    <p className="product__price">
                        <small>R</small>
                        <strong>{price}</strong>
                    </p>
                    <div className='product__rating'>
                        {Array(rating)
                            .fill()
                            .map((_, i) => (
                            <p><StarRateIcon /></p>
                        ))}
                    </div>
                </div>
                <img src={image} 
                     alt={alt} 
                />
                <button onClick={addToBasket}> Add to basket</button>
            </div>
        </>
    )
}
export default Product;