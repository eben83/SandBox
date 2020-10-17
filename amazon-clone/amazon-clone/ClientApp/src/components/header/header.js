import React from 'react';

import './header.scss.sass'

const Header = () => {
    return (
        <>
            <div className='header'>
                <img className='header__logo' 
                     src='http://pngimg.com/uploads/amazon/amazon_PNG25.png' 
                     alt='logo'/>
                     
                 <div className='header__search'>
                     <input className='header__search-input' type='text' />
                 </div>
            </div>
        </>
    )
}
export default Header;