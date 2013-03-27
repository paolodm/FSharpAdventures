
module Assignment2
    open System

    let balance (chars:string) = 
        let rec calc (remaining:string) =
            let start_ind = remaining.IndexOf("(")
            let end_ind = remaining.LastIndexOf(")")
            
            //Console.WriteLine("Start: {0}", start_ind)
            //Console.WriteLine("End: {0}", end_ind)
            Console.WriteLine("Remaining: {0}", remaining)


            if start_ind > end_ind then
                false
            elif start_ind = -1 then
                end_ind = -1
            elif end_ind = -1 then
                start_ind = -1
            else
                let substr = remaining.Substring(start_ind + 1, (end_ind - start_ind - 1))
                calc substr
        calc chars 

    let ans1 = balance "(if (zero? x) max (/ 1 x))"
    let ans2 = balance "I told him (that it’s not (yet) done). (But he wasn’t listening)"
    let ans3 = balance ":-)"
    let ans4 = balance "())("
