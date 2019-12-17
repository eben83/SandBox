//
//  Meal.swift
//  MealTracker
//
//  Created by Eben Burger on 2019/09/09.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Meal {
    var name: String
    var food: [Food]
    
    init( name: String, food: [Food]) {
        self.name = name
        self.food = food
    }
}

var mealList: [Meal] = [
    Meal(name: "Breakfast", food: foodList),
    Meal(name: "Lunch", food: foodList),
    Meal(name: "Dinner", food: foodList)
    
]
