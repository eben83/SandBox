//
//  Emoji.swift
//  EmojiDictionary
//
//  Created by Eben Burger on 2019/09/05.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation


let emojiTableViewController = EmojiTableViewController()

struct Emoji: Codable {
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
    
    
    //saves the data
    static func saveToFile(emoji: Emoji) {
        let propertyListEncoder = PropertyListEncoder()
        let encodedEmoji = try? propertyListEncoder.encode(emojis)
        try? encodedEmoji?.write(to: archiveURL, options: .noFileProtection)
    }
    
    //loads the data
    static func loadFromFile() -> [Emoji] {
        let propertyListDecoder = PropertyListDecoder()
        
        if let retrivedEmojiData = try? Data(contentsOf: archiveURL),
            let decodedEmoji = try? propertyListDecoder.decode(Array<Emoji>.self, from: retrivedEmojiData) {
            print(decodedEmoji)
        }
        return emojis
    }
    
    
    // loads the sample data form the 1st list of emojis made
    static func loadSampleEmoji() {
        
    }
}

let documentDirectory = FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first!
let archiveURL = documentDirectory.appendingPathComponent("Documents/emoji").appendingPathExtension("plist")


