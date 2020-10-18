import React from 'react'
import Subtotal from "../../components/subtotal/subtotal";

import './checkout.css'

const Checkout =() => {
    return (
        <>
        <div className='checkout'>
            <div className='checkout__left'>
                <div>
                    <h2 className='checkout__title'>Your Shopping Basket</h2>
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