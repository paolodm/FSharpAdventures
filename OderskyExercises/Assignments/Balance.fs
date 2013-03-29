
module Assignment2
    open System

    let balance (chars:string) = 
        let rec calc (remaining:string) (acc:int) =
            if remaining.Length > 0 then
                let first = remaining.[0]
                let left = remaining.Substring(1)
            
                if acc < 0 then
                    acc 
                elif first = '(' then
                    calc left (acc + 1)
                elif first = ')' then
                    calc left (acc - 1)
                else
                    calc left acc
            else
                acc
        let acc = 0
        let result = calc chars acc
        result = 0

    let ans1 = balance "(if (zero? x) max (/ 1 x))"
    let ans2 = balance "I told him (that it’s not (yet) done). (But he wasn’t listening)"
    let ans3 = balance ":-)"
    let ans4 = balance "())("

