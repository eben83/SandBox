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
        
        //this addes the title text
        navigationItem.title = "Emoji Shit"
        navigationItem.rightBarButtonItem?.title = "Add"
        tableView.rowHeight = UITableView.automaticDimension
        tableView.estimatedRowHeight = 44.0
    }

    // MARK: - Table view data source

    override func numberOfSections(in tableView: UITableView) -> Int {
        // this adds the number of sections.
        return emojis.count
    }

    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        
        if section == 0 {
            return emojis.count
        } else {
            return 0
        }
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "EmojiCell", for: indexPath) as! EmojiTableViewCell //this uses the EmojiTableView file
        
        
        /*
        this is not needed to set the cells anymore as the cells are set in the
        new Emoji Table View Cell shift file
         
        
         cell.textLabel?.text = "\(emoji.symbol) - \(emoji.name)"
         cell.detailTextLabel?.text = emoji.description
        */
        
        //fetch the model object to display
        let emoji = emojis[indexPath.row]

        
        //this in the new setup/ config for the cells
        cell.update(with: emoji)
        
        //this adds the reorder function to the table
        cell.showsReorderControl = true

        return cell
    }
    
    /*
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        //this prints the user selection to the console
        let emoji = emojis[indexPath.row]
        print("\(emoji.symbol) \(indexPath)")
    }
 */
    

    // Override to support rearranging the table view.
    override func tableView(_ tableView: UITableView, moveRowAt fromIndexPath: IndexPath, to: IndexPath) {
        let movedEmoji = emojis.remove(at: fromIndexPath.row)
        emojis.insert(movedEmoji, at: to.row)
        tableView.reloadData()
    }
    
    //this removes/ hides the delete button
    override func tableView(_ tableView: UITableView, editingStyleForRowAt Path: IndexPath) -> UITableViewCell.EditingStyle {
        // returning none will not allow for editing on the cells
        // there are two other options delete and insert for this section.
        return .delete
    }
    
    // this will reload
    override func viewWillAppear(_ animated: Bool) {
        tableView.reloadData()
    }
    
    
    /*
     // Override to support conditional editing of the table view.
     
     
     override func tableView(_ tableView: UITableView, canEditRowAt indexPath: IndexPath) -> Bool {
     // Return false if you do not want the specified item to be editable.
     return true
     }
     */
    
    
    
     // Override to support editing the table view.
     override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        if editingStyle == .delete {
            emojis.remove(at: indexPath.row)
            tableView.deleteRows(at: [indexPath], with: .automatic) //automatic sets the swipe delete as well.
            //this deletes the row from the source
        }
        else if editingStyle == .insert {
            // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
        }
     }
    
    
    /*
     // Override to support conditional rearranging of the table view.
     
     override func tableView(_ tableView: UITableView, canMoveRowAt indexPath: IndexPath) -> Bool {
     // Return false if you do not want the item to be re-orderable.
     return true
     }
     */
    
    
    /*
     the segue function below :
     1st checks the identifier
     access the destination UINavigationController
     downcast its top view controller
     access the object(s)
     then assign the properties
 */
     override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "EditEmoji" {
            let indexPath = tableView.indexPathForSelectedRow!
            let emoji = emojis[indexPath.row]
            let navController = segue.destination as! UINavigationController
            let addEditEmojiTableViewController = navController.topViewController as! AddEditEmojiTableViewController
            
            addEditEmojiTableViewController.emoji = emoji
        }
     }
    
    /*
     this segue is from the save and cancel button
    */
    @IBAction func unwindToEmojiTableView(segue: UIStoryboardSegue) {

        guard segue.identifier == "saveUnwind",
        let sourceViewController = segue.source as? AddEditEmojiTableViewController,
        let emoji = sourceViewController.emoji else { return }
        
        if let selectedIndexPath = tableView.indexPathForSelectedRow {
            emojis[selectedIndexPath.row] = emoji
            tableView.reloadRows(at: [selectedIndexPath], with: .none)
        } else {
            let newIndexPath = IndexPath(row: emojis.count, section: 0)
            emojis.append(emoji)
            tableView.insertRows(at: [newIndexPath], with: .automatic)
        }

        //let sourceViewController = unwindSegue.source
        // Use data from the view controller which initiated the unwind segue
    }
    
    

}
