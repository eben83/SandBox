//
//  ViewController.swift
//  Contest
//
//  Created by Eben Burger on 2019/10/31.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet var emailAddressTextField: UITextField!
    @IBOutlet var submitButtonTapped: UIButton!
    
    
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        navigationItem.title = "Competition Time"
    }
    
    @IBAction func submitButtonTapped(_ sender: UIButton) {
        if emailAddressTextField.text == "" {
            
        } else {
        }
    }
    
}

