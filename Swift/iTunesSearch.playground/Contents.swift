import UIKit
import PlaygroundSupport

PlaygroundPage.current.needsIndefiniteExecution = true

struct StoreItem: Codable {
    var artist: String
    var songName: String
    var albumArtwork: UIImage?
    
    enum CodingKeys: Any, CodingKey {
        case artist = "artistName"
        case songName //= "trackName"
        case albumArtwork
    }
    
    init( from decoder: Decoder) throws {
        let valueContainer = try decoder.container(keyedBy: CodingKeys.self)
        
        self.artist = try valueContainer.decode(String.self, forKey: CodingKeys.artist)
    }
}

let baseURL = URL(string: "https://itunes.apple.com/search?")!

let query: [String: String] = [
    "term": "maroon"
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

let task = URLSession.shared.dataTask(with: url!) {(data, responce, error) in
    if let data = data,
        let string = String(data: data, encoding: .utf8) {
        print(string)
    }
    PlaygroundPage.current.finishExecution()
}
task.resume()
