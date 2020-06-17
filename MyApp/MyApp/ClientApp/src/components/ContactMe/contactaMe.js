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
        }
        
        const submitHandler = (e) => {
            
            console.log(form)
            e.preventDefault();
        }

    return(
        <form className="d-flex flex-column col-3 align-content-center needs-validation" onSubmit={submitHandler}>
            
            <input type="text" name="first_name" placeholder="Name"
                    value={form.first_name}       
                   onChange={(e) => changeHandler(e)}
                   required
            />
                   
            <input type="text" name="surname" placeholder="Surname"
                    value={form.surname}       
                   onChange={(e) => changeHandler(e)}/>
                   
            <button className="btn btn-primary btn-lg" type="submit">Submit</button>
            
        </form>
    );
}
export default ContactMe;