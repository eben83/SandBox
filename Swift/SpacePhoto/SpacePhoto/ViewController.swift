//
//  ViewController.swift
//  SpacePhoto
//
//  Created by Eben Burger on 2019/11/14.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    
    @IBOutlet weak var imageView: UIImageView!
    @IBOutlet weak var descriptionLabel: UILabel!
    @IBOutlet weak var copyrightLabel: UILabel!
    
    let photoInfoController = PhotoInfoController()
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        descriptionLabel.text = ""
        copyrightLabel.text = ""
        
        
        photoInfoController.fetchPhotoInfo { ( PhotoInfo ) in
            guard let photoInfo = PhotoInfo else { return }
            DispatchQueue.main.async {  //this pushes the following code to the main Queue- so that it can run 1st
                if let photoInfo = photoInfo {
                    self.updateUI(with: photoInfo)
                }
                if let photoInfo = photoInfo {
                    self.updateUI(with: photoInfo)
                }
                /*
                self.title = photoInfo.title    // settin gthe title label
                self.descriptionLabel.text = photoInfo.description     //setting the description label
                if let copyright = photoInfo.copyright {                // if there is a copyright- it will show- else nothing will display.
                    self.copyrightLabel.text = "Copyright \(copyright)"
                } else {
                    self.copyrightLabel.isHidden = true
                }
                */
            }
        }
    }
    func updateUI(with photoInfo: PhotoInfo) {
        let task = URLSession.shared.dataTask(with: photoInfo.url, completionHandler: {
            (data, response, error) in
            
            guard let data = data,
                let image = UIImage(data: data) else { return }
            DispatchQueue.main.async {
                self.title = photoInfo.title
                self.imageView.image = image
                self.descriptionLabel.text = photoInfo.description
                
                if let copyright = photoInfo.copyright {
                    self.copyrightLabel.text = "Copyright \(copyright)"
                } else {
                    self.copyrightLabel.isHidden = true
                }
            }
        })
        task.resume()
    }
}
