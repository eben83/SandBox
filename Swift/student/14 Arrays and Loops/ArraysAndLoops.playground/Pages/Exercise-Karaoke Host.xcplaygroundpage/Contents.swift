/*:
 ## Exercise: Karaoke Host

 You have a friend who loves singing karaoke with a big group of people. The karaoke singers add songs they’d like to sing to a list and the karaoke host calls out the songs one by one. 
 
 Your friend and has asked you to write software to help manage the song list.

 - callout(Exercise):
 Create an empty array to hold song titles as strings, and use the `append` method to add three or four songs one at a time.
 */
var songTitle =  [String]()

songTitle.append("dancing on Mondays")
songTitle.append("New Night")
songTitle.append("Now or Never")




/*:
 - callout(Exercise):
 One enthusiastic singer wants to add three songs at once. Create an array holding this one singer's song list and use the `+=` operator to append their whole list to the end of the group's song list.
 */
var singerTitle = [String]()

singerTitle += ["Can't dance", "Tusday school", "fight night"]

songTitle += singerTitle

songTitle
singerTitle




/*:
 - callout(Exercise):
 Write a `for…in` loop and, for every song title in the array, print an encouraging announcement to let the next singer know that it's their turn.
 */
for singer in songTitle {
    let singerMessage = "🎵𝄫𝄢🚦🚥\(singer)🚥🚦᭤᭣᭡᭩"
    print("hey, person this is your song with the name \(singerMessage)")
}
print("everyone has the messages")




/*:
 - callout(Exercise):
 After the loop has called everyone up to sing, use the `removeAll` method on the song list to clear out all the past songs.
 */
songTitle.removeAll()
songTitle



//: [Previous](@previous)  |  page 14 of 17  |  [Next: Exercise: Counting Votes](@next)
