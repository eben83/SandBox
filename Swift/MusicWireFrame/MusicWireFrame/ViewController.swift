//
//  ViewController.swift
//  MusicWireFrame
//
//  Created by Eben Burger on 2019/10/30.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    var isPlaying: Bool = true {
        didSet {
            if isPlaying {
                playPauseButton.setImage(UIImage(named: "pause")!, for: .normal)
            } else {
                playPauseButton.setImage(UIImage(named: "play")!, for: .normal)
            }
        }
    }
    
    @IBOutlet var albumImageView: UIView!
    @IBOutlet var reverseBackground: UIView!
    @IBOutlet var PlayPauseBackground: UIView!
    @IBOutlet var forwardBackground: UIView!
    @IBOutlet var reverseButton: UIButton!
    @IBOutlet var playPauseButton: UIButton!
    @IBOutlet var forwardButton: UIButton!
    

    override func viewDidLoad() {
        super.viewDidLoad()
        
        reverseBackground.layer.cornerRadius = 35.0
        reverseBackground.clipsToBounds = true
        reverseBackground.alpha = 0.0
        
        PlayPauseBackground.layer.cornerRadius = 35.0
        PlayPauseBackground.clipsToBounds = true
        PlayPauseBackground.alpha = 0.0
        
        forwardBackground.layer.cornerRadius = 35.0
        forwardBackground.clipsToBounds = true
        forwardBackground.alpha = 0.0
    }

    
    @IBAction func playPauseButtonTapped() {
        if isPlaying {
            UIView.animate(withDuration: 0.5) {
                self.albumImageView.transform = CGAffineTransform(scaleX: 0.8, y: 0.8)
            }
            } else {
                UIView.animate(withDuration: 0.5, animations: {
                    self.albumImageView.transform = CGAffineTransform.identity
                })
            }
            isPlaying.toggle()
        }
    @IBAction func touchedDown(_ sender: UIButton) {
        let buttonBackground: UIView
        
        switch sender {
        case reverseButton:
            buttonBackground = reverseBackground
        case playPauseButton:
            buttonBackground = PlayPauseBackground
        case forwardButton:
            buttonBackground = forwardBackground
        default:
            return
        }
        
        UIView.animate(withDuration: 0.25) {
            buttonBackground.alpha = 0.3
            sender.transform = CGAffineTransform(scaleX: 0.8, y: 0.8)
        }
    }
    
    @IBAction func touchUpInside(_ sender: UIButton) {
        let buttonBackground: UIView
        
        switch sender {
        case reverseButton:
            buttonBackground = reverseBackground
        case playPauseButton:
            buttonBackground = PlayPauseBackground
        case forwardButton:
            buttonBackground = forwardBackground
        default:
            return
        }
        
        UIView.animate(withDuration:0.25, animations: {
            buttonBackground.alpha = 0.0
            buttonBackground.transform = CGAffineTransform(scaleX: 1.2, y: 1.2)
            sender.transform = CGAffineTransform.identity
        }) {(_) in
            buttonBackground.transform = CGAffineTransform.identity
        }
    }
}

