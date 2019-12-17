//
//  ULR+Helpers.swift
//  SpacePhoto
//
//  Created by Eben Burger on 2019/11/14.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

/*
 extension URL {
     func withQueries(_ queries: [String: String]) -> URL? {
         var components = URLComponents(url: self, resolvingAgainstBaseURL: true)
         components?.queryItems = query.map { URLQueryItem (name: $0.0, value: $0.1) }
         return components?.url
     }
 }

 */
extension URL {
    func withQueries(_ queries: [String: String]) -> URL? {
        var components = URLComponents(url: self,
                                       resolvingAgainstBaseURL: true)
        components?.queryItems = queries.map
            { URLQueryItem(name: $0.0, value: $0.1)}
        return components?.url
    }
}
