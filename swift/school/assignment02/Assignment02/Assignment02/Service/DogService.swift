//
//  DogService.swift
//  Assignment02
//
//  Created by dave noonz on 2021-02-23.
//

import Foundation

class DogService {
    
    static let shared = DogService()
    let BASE_URL = "https://dog.ceo/api/breeds/list/all"
    let IMAGE_URL = "https://dog.ceo/api/breeds/image/random/"
    
    // return array of Dog once completed
    func fetchDogs(completion: @escaping ([Dog]) -> () ) {
    
        guard let url = URL(string: BASE_URL) else { return }
        URLSession.shared.dataTask(with: url) { (data, response, error) in

            // handle error first
            if let error = error {
                print("Failed to fetch data with error: ", error.localizedDescription)
                return
            }

            let decoder = JSONDecoder()
            
            // collect data from URL
            guard let data = data else { return }
  
            print(data)
            if let result = try?
                decoder.decode(Dog.self, from: data) {
                print(result)
                completion([result])
            }
        }.resume()
    }
    
    func fetchImage(completion: @escaping ([Image]) ->() ) {
        
        guard let url = URL(string: IMAGE_URL) else { return}
        URLSession.shared.dataTask(with: url) { (data, response, error) in
            if let error = error {
                print("Failed to fetch data with error: ", error.localizedDescription)
                return
            }
            
            let decoder = JSONDecoder()
            
            // collect data from URL
            guard let data = data else { return }
            
            if let result = try? decoder.decode(Image.self, from: data) {
                completion([result])
            }
        }.resume()
    }
}
