//
//  ViewController.swift
//  RPS
//
//  Created by Eben Burger on 2019/07/01.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet weak var appSign: UILabel!
    @IBOutlet weak var gameStatus: UILabel!
    @IBOutlet weak var rock: UIButton!
    @IBOutlet weak var paper: UIButton!
    @IBOutlet weak var scissors: UIButton!
    @IBOutlet weak var playAgain: UIButton!
    
    //sets the computer choice to the function.
    
    override func viewDidLoad() {
        super.viewDidLoad()
        gameStatus.text = "Rock, Paper, Scissors"
        playAgain.isHidden = true
        // Do any additional setup after loading the view.
    }
   
    @IBAction func rock(_ sender: Any) {
        paper.isHidden = true
        scissors.isHidden = true
        playAgain.isHidden = false
        appSign.text = computer.emoji
        gameStatus.text = rockGame
        
    }
    @IBAction func paper(_ sender: Any) {
        rock.isHidden = true
        scissors.isHidden = true
        playAgain.isHidden = false
        appSign.text = computer.emoji
        gameStatus.text = gamePlay(.paper, computer)
        
    }
    @IBAction func scissors(_ sender: Any) {
        rock.isHidden = true
        paper.isHidden = true
        playAgain.isHidden = false
        appSign.text = computer.emoji
        gameStatus.text = gamePlay(.scissors, computer)
        
    }
    @IBAction func playAgain(_ sender: Any) {
        rock.isHidden = false
        paper.isHidden = false
        scissors.isHidden = false
        
        gameStatus.text = "Rock, Paper, Scissors"
        playAgain.isHidden = true
        
        
    }
}

