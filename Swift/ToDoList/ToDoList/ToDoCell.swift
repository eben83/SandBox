//
//  ToDoCell.swift
//  ToDoList
//
//  Created by Eben Burger on 2019/10/23.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ToDoCell: UITableViewCell {
    
    @IBOutlet var isCompleteButton: UIButton!
    @IBOutlet var titleLabel: UILabel!
    
    weak var delegate: ToDoCellDelegate?
    

    override func awakeFromNib() {
        super.awakeFromNib()
        // Initialization code
    }

    override func setSelected(_ selected: Bool, animated: Bool) {
        super.setSelected(selected, animated: animated)

        // Configure the view for the selected state
    }
    
    
    @IBAction func completeButtonTapped() {
        delegate?.checkmarkTapped(sender: self)
    }
}

protocol ToDoCellDelegate: class {
    func checkmarkTapped(sender: ToDoCell)
}
