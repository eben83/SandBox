import React from 'react';

import './home.css'
import Product from "../../components/product/product";

const Home = () => {
    return (
        <>
            <div className='home'>
                <div className='home__container'>
                    <img 
                        className='home__image'
                        src='https://techwiztime.com/wp-content/uploads/2016/08/amazon-prime-free-30-day-trial-banner-techwiztime.jpg'
                        alt='amazon banner'
                    />
                    <div className='home__row'>
                        <Product />
                        <Product />
                    </div>
                    <div className='home__row'>
                        <Product />
                        <Product />
                        <Product />
                    </div>
                    <div className='home__row'>
                        <Product />
                    </div>
                </div>
            </div>
        </>
    )
}
export default Home;