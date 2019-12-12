//
//  ViewController.swift
//  AnimalSounds
//
//  Created by Eben Burger on 2019/06/26.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet weak var animalSoundLabel: UILabel!
    
    let meowSound = SimpleSound(named: "meow")
    let woofSOund = SimpleSound(named: "woof")
    let mooSound = SimpleSound(named: "moo")
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func catButtonTapped(_ sender: Any) {
        animalSoundLabel.text = "Meow !"
        meowSound.play()
    }
    
    @IBAction func dogButtonTapped(_ sender: Any) {
        animalSoundLabel.text = "Woof !"
        woofSOund.play()
    }
    
    @IBAction func cowButtonTapped(_ sender: Any) {
        animalSoundLabel.text = "Moo !"
        mooSound.play()
    }
}

