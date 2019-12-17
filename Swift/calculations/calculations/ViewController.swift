//
//  ViewController.swift
//  calculations
//
//  Created by Eben Burger on 2019/07/03.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var Answer: UILabel!
    @IBOutlet weak var numberOneText: UITextField!
    @IBOutlet weak var numberTwoText: UITextField!
    @IBOutlet weak var numberThreeText: UITextField!
    @IBOutlet weak var numberButton: UIButton!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func numberButton(_ sender: Any) {
        
        }
    
    func calculations(firstNumber: Int, secondNumber: Int, thirdNumber: Int) -> Int {
        
        let answerResult = numberOneText + numberTwoText + numberThreeText
        return answerResult
    }
}


