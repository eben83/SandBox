//
//  ViewController.swift
//  Light
//
//  Created by Eben Burger on 2019/07/08.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    var lighOn = true

    override func viewDidLoad() {
        super.viewDidLoad()
        update()
        // Do any additional setup after loading the view.
    }

    @IBAction func buttonPressed(_ sender: Any) {
        lighOn.toggle()
        update()
    }
    
    func update() {
        view.backgroundColor = lighOn ? .white : .black
    }
    
}

