//
//  AthleteFormViewController.swift
//  FavoriteAthlete
//
//  Created by Eben Burger on 2019/08/30.
//

import Foundation
import UIKit

class AthleteFormViewController: UIViewController {
    
    
    override func viewDidLoad() {
    super.viewDidLoad()
        updateView()
    
    }
    
    @IBOutlet var nameLabel: UITextField!
    @IBOutlet var ageLabel: UITextField!
    @IBOutlet var leageLabel: UITextField!
    @IBOutlet var teamLabel: UITextField!
    
    
    var athlete: Athlete?
    
    func updateView() {
        if athlete != nil {
            return
        } else {
            
            /*
            let name = nameLabel.text!
            let age = Int(ageLabel.text!)
            let leage = leageLabel.text!
            let team = teamLabel.text!
            */
            //athlete = Athlete(name: name, age: age!, League: leage, team: team)
            return
        
        }
        return
    }
    
    @IBAction func saveButton(_ sender: Any) {
        guard let name = nameLabel.text,
            let age = Int(ageLabel.text!),
        let league = leageLabel.text,
        let team = teamLabel.text
            else { return }
        
        athlete = Athlete(name: name, age: age, League: league, team: team)
    }
    
    
}
