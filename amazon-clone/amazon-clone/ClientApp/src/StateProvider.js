import React, { createContext, useContext, useReducer } from 'react';

const SateProvider = ({ reducer, initialState, children}) => {
    const StateContext = createContext();
     return (
         <StateContext.Provider value={useReducer(reducer, initialState)}>
             {children}
         </StateContext.Provider>
     )
    
}
export default SateProvider;