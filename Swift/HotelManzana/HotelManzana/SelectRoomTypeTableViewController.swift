//
//  SelectRoomTypeTableViewController.swift
//  HotelManzana
//
//  Created by Eben Burger on 2019/09/30.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class SelectRoomTypeTableViewController: UITableViewController {
    
    //made a variable to hold the currently selected RoomType- it's an optional because the staff wouldn't have collected the room typas yet.
    var roomType: RoomType?
    
    //pulled in the protocol below
    weak var delegate: SelectRoomTypeTableViewControllerDelegate?

    override func viewDidLoad() {
        super.viewDidLoad()
        navigationItem.title = "Select Room Type"
        

        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem
    }

    // MARK: - Table view data source

    override func numberOfSections(in tableView: UITableView) -> Int {
        // #warning Incomplete implementation, return the number of sections
        return 1
    }

    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        // #warning Incomplete implementation, return the number of rows
        return RoomType.all.count
    }
    
    // this is an array of room types as type property on RoomType
    

    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        //set the reusable cell name to the Identifier name set in StoryBoard
        let cell = tableView.dequeueReusableCell(withIdentifier: "RoomTypeCell", for: indexPath)
        
        //indexed the rows for the roomTypes
        let roomType = RoomType.all[indexPath.row]
        
        //setting the cell label to the room type name
        cell.textLabel?.text = roomType.name
        
        //setting the cell detail to the price
        cell.detailTextLabel?.text = "$ \(roomType.price)"
        
        //this adds a check mark (tick) next to the selected room type
        if roomType == self.roomType {
            cell.accessoryType = .checkmark
        } else {
            cell.accessoryType = .none
        }
        
        //returns the room type
        return cell
    }
    
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        tableView.deselectRow(at: indexPath, animated: true)
        roomType = RoomType.all[indexPath.row]
        //this statement calls the delegate method
        delegate?.didSelect(roomType: roomType!)
        tableView.reloadData()
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
    // Override to support rearranging the table view.
    override func tableView(_ tableView: UITableView, moveRowAt fromIndexPath: IndexPath, to: IndexPath) {

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

}


//
protocol SelectRoomTypeTableViewControllerDelegate: class {
    func didSelect(roomType: RoomType)
}
