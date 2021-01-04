import React from 'react'
import Subtotal from "../../components/subtotal/subtotal";
import {useStateValue} from "../../StateProvider";
import CheckoutProducts from "../../components/checkout-products/checkout-products";

import './checkout.css'

const Checkout =() => {
    const [{basket}] = useStateValue()
    return (
        <>
        <div className='checkout'>
            <div className='checkout__left'>
                <div>
                    <h2 className='checkout__title'>Your Shopping Basket</h2>

                    {basket.map(item => (
                        <CheckoutProducts
                            id={item.id}
                            title={item.title}
                            image={item.image}
                            alt={item.alt}
                            price={item.price}
                            rating={item.rating}
                        />
                    ))}
                </div>
            </div>
            <div className='checkout__right'>
                <Subtotal />
            </div>
        </div>
        </>
    )
}
export default Checkout;