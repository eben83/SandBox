//
//  ViewController.swift
//  AppEventCount
//
//  Created by Eben Burger on 2019/08/28.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

   
    
    @IBOutlet var didFinishLaunchingLabel: UILabel!
    @IBOutlet var willResignActiveLabel: UILabel!
    @IBOutlet var didEnterBackgroundLabel: UILabel!
    @IBOutlet var willEntreForegroundLabel: UILabel!
    @IBOutlet var didBecomeActiveLabel: UILabel!
    @IBOutlet var willTerminateLabel: UILabel!
    
    var launchCount = 0
    var resignActiveCount = 0
    var enterBackgroundCount = 0
    var enterForegroundCount = 0
    var becomeActiveCount = 0
    var terminateCount = 0
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        //updateView()
    }
    
    
    
    func updateView() {
        didFinishLaunchingLabel.text = "The app has launched \(launchCount) time(s)"
        willResignActiveLabel.text = "The app is resign active \(resignActiveCount) time(s)"
        didEnterBackgroundLabel.text = "The app was in the background \(enterBackgroundCount) time(s)"
        willEntreForegroundLabel.text = "The app will enter the Foreground \(enterForegroundCount) time(s)"
        didBecomeActiveLabel.text = "The app became active \(becomeActiveCount) time(s)"
        willTerminateLabel.text = "The app terminated \(terminateCount) time(s)"
    }
}


