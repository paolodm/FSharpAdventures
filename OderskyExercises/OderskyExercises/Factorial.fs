
// This implementation is not tail-recursive
let rec factorial n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | n -> n * factorial(n-1)

let ans = factorial 10;;

// This implementation is tail recursive due to the use of the 
// accumulator.
let factorial' n =
    let rec loop (acc: int) (n: int) =
        if n = 0 then acc
        else loop (acc * n) (n - 1)
    loop 1 n

let ans2 = factorial' 10;;