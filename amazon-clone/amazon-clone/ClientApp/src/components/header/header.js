import React from 'react';
import {Link} from "react-router-dom";


import SearchIcon from '@material-ui/icons/Search';
import ShoppingBasketIcon from '@material-ui/icons/ShoppingBasket';

import './header.css'
const Header = () => {
    return (
        <>
            <div className='header'>
                <Link to="/">
                    <img className='header__logo'
                         src='http://pngimg.com/uploads/amazon/amazon_PNG25.png'
                         alt='logo'/>
                </Link>
                
                 <div className='header__search'>
                     <input className='header__search-input' type='text' />
                     <SearchIcon className="header__search-icon"/>
                 </div>
                
                <div className='header__nav'>
                    <div className='header_option'>
                        <span className='header__option-line-one'>Hello Guest</span>
                        <span className='header__option-line-two'>Sign in</span>
                    </div>
                    <div className='header_option'>
                        <span className='header__option-line-one'>Return</span>
                        <span className='header__option-line-two'>& Orders</span>
                    </div>
                    <div className='header_option'>
                        <span className='header__option-line-one'>Your</span>
                        <span className='header__option-line-two'>Prime</span>
                    </div>
                    
                    <Link to='/checkout'>
                        <div className='header__option-basket'>
                            <ShoppingBasketIcon />
                            <span className='header__option-line-two header__basket-count'>0</span>
                        </div>
                    </Link>
                </div>
            </div>
        </>
    )
}
export default Header;