struct MyQuestionAnswerer {
    func responseTo(question: String) -> String {
        let lowerQuestion = question.lowercased()
        if lowerQuestion.hasPrefix("hello"){
            return "Why, hello there!"
        } else if lowerQuestion.hasSuffix("cookies?") {
            return "in the cookie jar!!"
        }
        else if lowerQuestion.hasPrefix("where") {
            return "To the North"
        } else if lowerQuestion.hasPrefix("can") {
            return "You may- only after Dinner!"
        } else if lowerQuestion.hasPrefix("should") {
            return "You Can't leave"
        } else if lowerQuestion.hasPrefix("today") {
            return "The time is not important..."
        }
        
        return "This is unknown to me- Please try again."
    }
}
