//
//  Emoji.swift
//  EmojiDictionary
//
//  Created by Eben Burger on 2019/09/05.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Emoji {
    var symbol: String
    var name: String
    var description: String
    var usage: String
    
    init (symbol: String, name: String,
          description: String, usage: String) {
        self.symbol = symbol
        self.name = name
        self.description = description
        self.usage = usage
    }
}
