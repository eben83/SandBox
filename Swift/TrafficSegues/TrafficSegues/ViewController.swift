//
//  ViewController.swift
//  TrafficSegues
//
//  Created by Eben Burger on 2019/08/07.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    
    @IBOutlet var segueSwitch: UISwitch!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    @IBAction func yellowButtonTapped(_ sender: Any) {
        if segueSwitch.isOn {
            performSegue(withIdentifier: "Yellow", sender: nil)
        }
    }
    
    @IBAction func greenButtonTapped(_ sender: Any) {
        if segueSwitch.isOn {
            performSegue(withIdentifier: "Green", sender: nil)
        }
    }
}


