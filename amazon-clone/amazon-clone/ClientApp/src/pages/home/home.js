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
                        <Product 
                            title='The Lean Start'
                            image='https://images-na.ssl-images-amazon.com/images/I/51T-sMqSMiL._SX329_BO1,204,203,200_.jpg'
                            alt='Lean start up'
                            price={29.99}
                            rating={5}
                        />
                        <Product
                            title='AmazonBasics Moving and Storage Packing Tape,'    
                            image='https://images-na.ssl-images-amazon.com/images/I/71hqE%2BA%2BstL._AC_SL1500_.jpg'
                            alt="pacing Tape"
                            price={23.00}
                            rating={2}
                        />
                    </div>
                    <div className='home__row'>
                        <Product
                            title='AmazonBasics Enameled Cast Iron Dutch Oven - 6-Quart, Grey'    
                            image='https://images-na.ssl-images-amazon.com/images/I/818BtMx1D2L._AC_SL1500_.jpg'
                            alt='AmazonBasics Enameled Cast Iron Dutch Oven - 6-Quart, Grey'
                            price={1400}
                            rating={5}
                        />
                        <Product
                            title='Roku Streaming Stick+ | HD/4K/HDR Streaming Device with Long-range Wireless and Voice Remote with TV Controls'    
                            image='https://images-na.ssl-images-amazon.com/images/I/813T5unjeQL._AC_SL1500_.jpg'
                            alt='Roku Streaming Stick+ | HD/4K/HDR Streaming Device with Long-range Wireless and Voice Remote with TV Controls'
                            price={400}
                            rating={4}
                        />
                        <Product
                            title='SanDisk 128GB Extreme microSDXC UHS-I Memory Card with Adapter - C10, U3, V30, 4K, A2, Micro SD - SDSQXA1-128G-GN6MA '
                            image='https://images-na.ssl-images-amazon.com/images/I/815cRpgAN3L._AC_SL1500_.jpg'
                            alt='SanDisk 128GB Extreme microSDXC UHS-I Memory Card with Adapter - C10, U3, V30, 4K, A2, Micro SD - SDSQXA1-128G-GN6MA '
                            price={699}
                            rating={5}
                        />
                    </div>
                    <div className='home__row'>
                        <Product
                            title='Acer Aspire 5 Slim Laptop, 15.6 inches Full HD IPS Display, AMD Ryzen 3 3200U, Vega 3 Graphics, 4GB DDR4, 128GB SSD, Backlit Keyboard, Windows 10 in S Mode, A515-43-R19L, Silver '
                            image='https://images-na.ssl-images-amazon.com/images/I/61176H1a4cL._AC_SL1000_.jpg'
                            alt='Acer Aspire 5 Slim Laptop, 15.6 inches Full HD IPS Display, AMD Ryzen 3 3200U, Vega 3 Graphics, 4GB DDR4, 128GB SSD, Backlit Keyboard, Windows 10 in S Mode, A515-43-R19L, Silver '
                            price={10000}
                            rating={4}
                        />
                    </div>
                </div>
            </div>
        </>
    )
}
export default Home;