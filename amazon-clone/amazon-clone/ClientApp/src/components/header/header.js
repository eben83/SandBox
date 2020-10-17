import React from 'react';


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
                
                <div className='header__nav'>
                    <div className='header_option'>
                        <span className='hewader__option-line-one'>Hello Guest</span>
                        <span className='hewader__option-line-two'>Sign in</span>
                    </div>
                    <div className='header_option'>
                        <span className='hewader__option-line-one'>Return</span>
                        <span className='hewader__option-line-two'>& Orders</span>
                    </div>
                    <div className='header_option'>
                        <span className='hewader__option-line-one'>Your</span>
                        <span className='hewader__option-line-two'>Prime</span>
                    </div>
                </div>
            </div>
        </>
    )
}
export default Header;