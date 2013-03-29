module change

    open System
    open System.Collections.Generic

    let countChange (amount:int) (coins:list<'a>):int = 
        let breakdowns = new List<list<'a>>()

        let add_to_breakdowns breakdown = 
            let sorted = List.sort breakdown
            let alreadyAdded = breakdowns.Contains(sorted)
            
            if not alreadyAdded then
                breakdowns.Add(sorted)
                // List.append breakdowns sorted 
                Console.WriteLine(sorted)

        let rec loop remaining breakdown = 
            if remaining = 0 then
                add_to_breakdowns breakdown
            elif remaining > 0 then
                coins
                    |> Seq.filter(fun x -> remaining >= x)
                    |> Seq.iter(fun x -> loop (remaining - x) (x::breakdown))
                    |> ignore

        loop amount []

        breakdowns.Count

    let ans = countChange 4 [1; 2];
