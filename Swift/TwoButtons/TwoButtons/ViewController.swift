//
//  ViewController.swift
//  TwoButtons
//
//  Created by Eben Burger on 2019/07/18.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    
    @IBOutlet var lable: UILabel!
    @IBOutlet var textField: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    
    @IBAction func setTextButtonTapped(_ sender: Any) {
        lable.text = textField.text
    }
    
    
    @IBAction func clearTextButtonTapped(_ sender: Any) {
        textField.text = ""
        lable.text? = ""
    }
    
}

