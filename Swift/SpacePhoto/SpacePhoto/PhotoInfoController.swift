//
//  PhotoInfoController.swift
//  SpacePhoto
//
//  Created by Eben Burger on 2019/11/14.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation
import UIKit

class PhotoInfoController {
    
    
    
    
     func fetchPhotoInfo(completion: @escaping (PhotoInfo?) -> Void) {
         let baseURL = URL(string: "https://api.nasa.gov/planetary/apod")!
         
         let query: [String: String] = [
             "api_key": "DEMO_KEY",
         ]
         
         let url = baseURL.withQueries(query)!
         
         let task = URLSession.shared.dataTask(with: url) {
             (data, responce, error) in
             let jsonDecoder = JSONDecoder()
             
             if let data = data,
                 let photoInfo = try? jsonDecoder.decode(PhotoInfo.self, from: data) {
                 completion(photoInfo)
             } else {
                 print("Either no data was returned, or data was not serialized")
                 completion(nil)
             }
         }
         task.resume()
     }
     
   /*
    func fetchPhotoInfo(completion: @escaping (PhotoInfo?) -> Void) {
        let baseURL = URL(string: "https://api.nasa.gov/planetary/apod?")!

        let query: [String: String] = [
            "api_key": "DEMO_KEY",
        ]
        let url = baseURL.withQueries(query)!
        let task = URLSession.shared.dataTask(with: url) {(data,
                                                           response, error) in
            
            let jsonDecoder = JSONDecoder()
            
            if let data = data,
                let photoInfo = try? jsonDecoder.decode(PhotoInfo.self, from: data) {
                
               completion(photoInfo)
            } else {
                print("Either no data was returned, or data was not properly decoded.")
                completion (nil)
            }
//            PlaygroundPage.current.finishExecution()
        }
        task.resume()
    }
 */
    
}
