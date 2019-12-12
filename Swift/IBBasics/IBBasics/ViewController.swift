//
//  ViewController.swift
//  IBBasics
//
//  Created by Eben Burger on 2019/07/05.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet var myButton: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        myButton.setTitleColor(.red, for: .normal)
        // Do any additional setup after loading the view.
    }

    @IBAction func buttonPressed(_ sender: Any) {
        print("the button was pressed")
    }
    
}

