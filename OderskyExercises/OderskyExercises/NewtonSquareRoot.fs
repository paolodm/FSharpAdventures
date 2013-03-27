open System

let sqrt (x:Double) = 
    let isGoodEnough (guess:Double) =
        abs((guess * guess) - x) < 0.001

    let improve (guess:Double) = 
        (guess + x / guess) / 2.0

    let rec sqrtIter (guess:Double) =
        if isGoodEnough guess then guess
        else sqrtIter (improve guess)

    sqrtIter 1.0
    