import UIKit
import PlaygroundSupport

PlaygroundPage.current.needsIndefiniteExecution = true

/*
        this pulls data from the site below
let url = URL(string: "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY")!
let task = URLSession.shared.dataTask(with: url) { (data,
                                                    responce, error) in
    
    if let data = data,
        let string = String(data: data, encoding: .utf8) {
        print(string)
    }
    PlaygroundPage.current.finishExecution()
}

task.resume()
*/

/*
let baseURL = URL(string: "https://api.nasa.gov/planetary/apod?")!
    this is the query for the web address
let query: [String: String] = [
    "api_key": "DEMO_KEY",
    "date": "2011-07-13"
]
extension URL {
    func withQueries(_ queries: [String: String]) -> URL? {
        var components = URLComponents(url: self,
                                       resolvingAgainstBaseURL: true)
        components?.queryItems = queries.map
            { URLQueryItem(name: $0.0, value: $0.1)}
        return components?.url
    }
}

let url = baseURL.withQueries(query)
let task = URLSession.shared.dataTask(with: url!) {(data,
                                                   response, error) in
    if let data = data,
        let string = String(data: data, encoding: .utf8) {
        print(string)
    }
    PlaygroundPage.current.finishExecution()
    
}
task.resume()
*/

struct PhotoInfo: Codable {
    
    var title: String
    var description: String
    var url: URL
    var copyright: String?
    
    enum CodingKeys: String, CodingKey {
        case title
        case description = "explanation"
        case url
        case copyright
    }
    
    init(from decoder: Decoder) throws {
        let valueContainer = try decoder.container(keyedBy: CodingKeys.self)
        
        self.title = try valueContainer.decode(String.self, forKey: CodingKeys.title)
        self.description = try valueContainer.decode(String.self, forKey: CodingKeys.description)
        self.url = try valueContainer.decode(URL.self, forKey: CodingKeys.url)
        self.copyright = try? valueContainer.decode(String.self, forKey: CodingKeys.copyright)
    }
}


extension URL {
    func withQueries(_ queries: [String: String]) -> URL? {
        var components = URLComponents(url: self,
                                       resolvingAgainstBaseURL: true)
        components?.queryItems = queries.map
            { URLQueryItem(name: $0.0, value: $0.1)}
        return components?.url
    }
}



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
        PlaygroundPage.current.finishExecution()
    }
    task.resume()
}

fetchPhotoInfo { (fetchInfo) in
    print(fetchInfo)
}



