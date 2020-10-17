import React from 'react';
import SearchIcon from '@material-ui/icons/Search';

import './header.css'
const Header = () => {
    return (
        <>
            <div className='header'>
                <img className='header__logo' 
                     src='http://pngimg.com/uploads/amazon/amazon_PNG25.png' 
                     alt='logo'/>
                     
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
                </div>
            </div>
        </>
    )
}
export default Header;