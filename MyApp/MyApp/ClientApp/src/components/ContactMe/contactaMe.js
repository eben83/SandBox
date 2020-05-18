import React, { useState } from "react";

const ContactMe = () => {
    
        const [form, setForm] = useState({first_name:"", surname:""})
        
        const changeHandler = (e) => {
            const {name, value} = (e).target;
            // debugger;
            setForm(
                prevState => ({
                    ...prevState, [name]: value
                })
            )
            console.log(form)
        }
        
        const onSubmitHandler = (e) => {
            e.preventDefault();
            console.log(form)
            
        }
        

    return(
        <form className="d-flex flex-column col-3 align-content-center needs-validation" onSubmit={onSubmitHandler}>
            
            <input type="text" name="first_name" placeholder="Name"
                    value={form.first_name}       
                   onChange={(e) => changeHandler(e)}/>
                   
            <input type="text" name="surname" placeholder="Surname"
                    value={form.surname}       
                   onChange={(e) => changeHandler(e)}/>
                   
            <a className="btn btn-primary btn-lg" type="submit">Submit</a>
            
        </form>
    );
}
export default ContactMe;