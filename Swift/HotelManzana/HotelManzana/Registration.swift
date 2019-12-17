//
//  HotelManzana.swift
//  HotelManzana
//
//  Created by Eben Burger on 2019/09/26.
//  Copyright © 2019 Eben Burger. All rights reserved.
//

import Foundation

struct Registration {
    var firstName: String
    var lastName: String
    var emailAddress: String
    
    var checkInDate: Date
    var checkOutDate: Date
    var numberOfAdults: Int
    var numberOfChildren: Int
    
    var roomType: RoomType
    var wifi: Bool
}
