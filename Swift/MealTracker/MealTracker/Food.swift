//
//  Food.swift
//  MealTracker
//
//  Created by Eben Burger on 2019/09/09.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Food {
    var name: String
    var description: String
    
    init( name: String, description: String) {
        self.name = name
        self.description = description
    }
}

var foodList : [Food] = [
    Food(name: "Oats", description: "Milk not included"),
    Food(name: "Bacon and Eggs", description: "Best thing ever"),
    Food(name: "Toasted Cheese", description: "Fri'Yays")
]

var foodListTwo : [Food] = [
    Food(name: "toast", description: "Milk not included"),
    Food(name: "sweets", description: "Best thing ever"),
    Food(name: "butter", description: "Fri'Yays")
]

