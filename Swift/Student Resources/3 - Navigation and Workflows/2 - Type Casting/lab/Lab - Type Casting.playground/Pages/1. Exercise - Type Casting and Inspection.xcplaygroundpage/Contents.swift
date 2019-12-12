/*:
 ## Exercise - Type Casting and Inspection
 
 Create a collection of type [Any], including a few doubles, integers, strings, and booleans within the collection. Print the contents of the collection.
 */
var items: [Any] = [12, "peter", true, 13.5]
print(items)

/*:
 Loop through the collection. For each integer, print "The integer has a value of ", followed by the integer value. Repeat the steps for doubles, strings and booleans.
 */
let collectionItems = items
for item in collectionItems {
    if let Interger = item as? Int {
        print("this interger is \(Interger)")
    } else if let Str = item as? String {
        print("\(Str) is the name of a person")
    } else if let Booleans = item as? Bool {
        print("\(Booleans) this is a true or false kind of day")
    } else if let Double = item as? Double {
        print("\(Double) is more acurate than an Int")
    } else {
        print("you're out of scope")
    }
}

/*:
 Create a [String : Any] dictionary, where the values are a mixture of doubles, integers, strings, and booleans. Print the key/value pairs within the collection
 */
var mixtures: [String: Any] = ["one": 1, "two": 2.3, "three": true, "four": "Four"]


for mixture in mixtures {
    if let number = mixture.value as? Int {
        print("\(mixture.key) This is a whole number: \(number)")
    } else if let double = mixture.value as? Double {
        print("\(mixture.key) This a know as a double: \(double)")
    } else if let boolian = mixture.value as? Bool {
        print("\(mixture.key) This is a Bool- so True or false: \(boolian)")
    } else if let str = mixture.value as? String {
        print("\(mixture.key) Then lastley this is a string: \(str)")
    }
}

/*:
 Create a variable `total` of type `Double` set to 0. Then loop through the dictionary, and add the value of each integer and double to your variable's value. For each string value, add 1 to the total. For each boolean, add 2 to the total if the boolean is `true`, or subtract 3 if it's `false`. Print the value of `total`.
 */
var total: Double = 0

for total1 in mixtures {
    if let total = total1.value as? Int{
        print(Double(total) + 1)
    } else if let total = total1.value as? Double {
        print(total + 2.3)
    } else if let total = total1.value as? Bool {
        print(total)
    } else if let total = total1.value as? String {
        print(total)
    }
}

/*:
 Create a variable `total2` of type `Double` set to 0. Loop through the collection again, adding up all the integers and doubles. For each string that you come across during the loop, attempt to convert the string into a number, and add that value to the total. Ignore booleans. Print the total.
 */
var total2: Double = 0

for total3 in mixtures {
    if let total2 = total3.value as? Int {
        print(Double(total2))
    } else if let total2 = total3.value as? Double {
        print(total2)
    } else if let total2 = total3.value as? String {
        print(total2)
    } else if let total2 = total3.value as? Bool {
        print(total2)
    }
}

//: page 1 of 2  |  [Next: App Exercise - Workout Types](@next)
