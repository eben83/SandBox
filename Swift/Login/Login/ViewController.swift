//
//  ViewController.swift
//  Login
//
//  Created by Eben Burger on 2019/08/07.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet var username: UITextField!
    @IBOutlet var forgotUserNameButton: UIButton!
    @IBOutlet var forgotPasswordButton: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    //this changes the text on the title to the text in username text field
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        //segue.destination.navigationItem.title = username.text
        
        guard let sender = sender as? UIButton else { return }
        
        // this is the segue for the forgot password button
        if sender == forgotPasswordButton {
            segue.destination.navigationItem.title = "Forgot Password"
        }
        //this is the segue for the forgot user name
        else if sender == forgotUserNameButton {
            segue.destination.navigationItem.title = "Forgot User Name"
        } else {
            // uses text from the username text field
            segue.destination.navigationItem.title = username.text
        }
    }
    
    @IBAction func forgotUserName(_ sender: Any) {
        performSegue(withIdentifier: "loginToLanding", sender: forgotUserNameButton)
    }
    
    @IBAction func forgotPassword(_ sender: Any) {
        performSegue(withIdentifier: "loginToLanding", sender: forgotPasswordButton)
    }
    
}

