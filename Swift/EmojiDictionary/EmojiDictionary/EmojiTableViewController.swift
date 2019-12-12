//
//  EmojiTableViewController.swift
//  EmojiDictionary
//
//  Created by Eben Burger on 2019/09/06.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit
import Foundation

class EmojiTableViewController: UITableViewController {
    

    override func viewDidLoad() {
        super.viewDidLoad()

        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // this puts an edit button on the navigation bar
        self.navigationItem.leftBarButtonItem = self.editButtonItem
    }

    // MARK: - Table view data source

    override func numberOfSections(in tableView: UITableView) -> Int {
        // this adds the number of sections.
        return 1
    }

    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        
        if section == 0 {
            return emojis.count
        } else {
            return 0
        }
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "EmojiCell", for: indexPath)
        let emoji = emojis[indexPath.row]
        
        cell.textLabel?.text = "\(emoji.symbol) - \(emoji.name)"
        cell.detailTextLabel?.text = emoji.description
        
        cell.showsReorderControl = true

        return cell
    }
    
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        let emoji = emojis[indexPath.row]
        print("\(emoji.symbol) \(indexPath)")
    }

    // Override to support rearranging the table view.
    override func tableView(_ tableView: UITableView, moveRowAt fromIndexPath: IndexPath, to: IndexPath) {
        let movedEmoji = emojis.remove(at: fromIndexPath.row)
        emojis.insert(movedEmoji, at: to.row)
        tableView.reloadData()
    }
    
    //this removes/ hides the delete button
    override func tableView(_ tableView: UITableView, editingStyleForRowAt Path: IndexPath) -> UITableViewCell.EditingStyle {
        return .none
    }
    
    // this will reload
    override func viewWillAppear(_ animated: Bool) {
        tableView.reloadData()
    }

    
    /*
     this struct is held in the Emoji.swift file
     */
    
    
    
    // this allowes you to edit the cells. making a Navigation Bar Item and then making the Action func,
    @IBAction func editButtonPressed(_ sender: UIBarButtonItem) {
        
        let tableViewEditionMode = tableView.isEditing
        
        tableView.setEditing(!tableViewEditionMode, animated: true)
    }
    
    /*
     // Override to support conditional editing of the table view.
     override func tableView(_ tableView: UITableView, canEditRowAt indexPath: IndexPath) -> Bool {
     // Return false if you do not want the specified item to be editable.
     return true
     }
     */
    
    
    /*
     // Override to support editing the table view.
     override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
     if editingStyle == .delete {
     // Delete the row from the data source
     tableView.deleteRows(at: [indexPath], with: .fade)
     } else if editingStyle == .insert {
     // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
     }
     }
     */
    
    
    /*
     // Override to support conditional rearranging of the table view.
     override func tableView(_ tableView: UITableView, canMoveRowAt indexPath: IndexPath) -> Bool {
     // Return false if you do not want the item to be re-orderable.
     return true
     }
     */
    
    /*
     // MARK: - Navigation
     
     // In a storyboard-based application, you will often want to do a little preparation before navigation
     override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
     // Get the new view controller using segue.destination.
     // Pass the selected object to the new view controller.
     }
     */
    
    var emojis : [Emoji] = [
        Emoji(symbol: "😁", name: "Grinning Face", description: "A typical smiley face.", usage: "happiness"),
        Emoji(symbol: "😕", name: "Confused Face", description: "A confused, puzzled face.", usage: "unsure"),
        Emoji(symbol: "😍", name: "Heart Eyes", description: "A smiley face with hearts for eyes.", usage: "love of something; attractive"),
        Emoji(symbol: "👮🏻‍♂️", name: "Police Officer", description: "A police officer wearing a blue cap with a gold badge", usage: "person of authority"),
        Emoji(symbol: "🐢", name: "Turtle", description: "A cute turtle", usage: "Somthing Slow"),
        Emoji(symbol: "🐘", name: "Elephant", description: "A grey elephant", usage: "Good memory"),
        Emoji(symbol: "🍝", name: "Spaghetti", description: "A plate of spaghetti", usage: "spaghetti"),
        Emoji(symbol: "🎲", name: "Die", description: "A single die", usage: "Taking a risk, chance: game"),
        Emoji(symbol: "⛺️", name: "Tent", description: "A small Tent", usage: "camping"),
        Emoji(symbol: "📚", name: "Stack of books", description: "Three coloured books stacked on each other", usage: "Homework; Studying"),
        Emoji(symbol: "💔", name: "Broken heart", description: "A red, broken heart", usage: "extreme sadness"),
        Emoji(symbol: "💤", name: "Snore", description: "Three blues z\'s", usage: "tired, sleepiness"),
        Emoji(symbol: "🏁", name: "Checkered Flag", description: "A black- and - White flag", usage: "compatition"),
        Emoji(symbol: "🐶", name: "Dog", description: "A small white and brown dog", usage: "Used for happiness and playfull"),
        Emoji(symbol: "🤬", name: "Swearing", description: "Someone is very angry and wanting to tell someone to F**ck off", usage: "anger"),
        Emoji(symbol: "🍌", name: "banana", description: "A banana, fruit", usage: "fruit"),
        Emoji(symbol: "🎾", name: "tennis ball", description: "a type of ball used in a tennis game, match", usage: "Sporting")
    ]
}
