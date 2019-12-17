//
//  MiddleViewController.swift
//  OrderOfEvents
//
//  Created by Eben Burger on 2019/08/14.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class MiddleViewController: UIViewController {

    @IBOutlet var middleViewLable: UILabel!
    
    var eventNumber: Int = 1
    
    override func viewDidLoad() {
        super.viewDidLoad()
        print("MiddleViewController - View Did Load")
        
        if let existingText = middleViewLable.text {
            middleViewLable.text = "\n \(existingText) nEvent number \(eventNumber) was viewDidLoad"
            eventNumber += 1
        }

        // Do any additional setup after loading the view.
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        print("MiddleViewController - View Will Appear")
        
        if let existingText = middleViewLable.text {
            middleViewLable.text = "\n \(existingText) nEvent number \(eventNumber) was viewWillAppear"
            eventNumber += 1
        }
    }
    
    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        print("MiddleViewController - View Did Appear")
        
        if let existingText = middleViewLable.text {
            middleViewLable.text = "\n \(existingText) nEvent number \(eventNumber) was viewDidAppear"
            eventNumber += 1
        }
    }
    
    override func viewWillDisappear(_ animated: Bool) {
        super.viewWillDisappear(animated)
        print("MiddleViewController - View Will Disappear")
        
        if let existingText = middleViewLable.text {
            middleViewLable.text = "\n \(existingText) nEvent number \(eventNumber) was viewWillDisappear"
            eventNumber += 1
        }
    }
    
    override func viewDidDisappear(_ animated: Bool) {
        super.viewDidDisappear(animated)
        print("MiddleViewController - View Did Disappear")
        
        if let existingText = middleViewLable.text {
            middleViewLable.text = "\n \(existingText) nEvent number \(eventNumber) was viewDidDisappear"
            eventNumber += 1
        }
    }
}
