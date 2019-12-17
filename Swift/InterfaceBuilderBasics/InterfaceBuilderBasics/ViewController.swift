//
//  ViewController.swift
//  InterfaceBuilderBasics
//
//  Created by Eben Burger on 2019/07/08.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet var mainLabel: UILabel!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    
    @IBAction func changeTitle(_ sender: Any) {
        mainLabel.text = "this app rocks"
    }
    
}

