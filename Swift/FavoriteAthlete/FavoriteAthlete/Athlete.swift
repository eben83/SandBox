//
//  Athlete.swift
//  FavoriteAthlete
//
//  Created by Eben Burger on 2019/08/30.
//

import Foundation

struct Athlete {
    let name: String
    let age: Int
    let League: String
    let team: String
    
    var description: String {
        return "\(name) is \(age) years old and plays for the \(team) in the \(League)"
    }
}
