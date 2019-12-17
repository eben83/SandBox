//
//  ViewController.swift
//  Calculator
//
//  Created by Eben Burger on 2019/07/22.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet var numberButton: [UIButton]!
    @IBOutlet var displayLabel: UILabel!
    

    override func viewDidLoad() {
        super.viewDidLoad()
        displayLabel.text = "0"
        // Do any additional setup after loading the view.
    }

    /*
     the numbers work- only single numbers- not allowing more units
     the numbers are string only and not Int- figure out
    */
    
    @IBAction func numberTapped(_ sender: UIButton) {
        let number = sender.title(for: .normal)
        displayLabel.text = number
    }
    
    // resets the display
    @IBAction func clearButton(_ sender: Any) {
        displayLabel.text = "0"
    }
    
    //need to get the Percentage to calculate
    @IBAction func percentage(_ sender: UIButton) {
        
    }
}

