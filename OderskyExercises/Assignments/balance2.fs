module balance2

    let balance (input:string) = 

        // parens_ints is an array that represents the parens. 
        //      1 stands for '('. 
        //      -1 stands for ')'.
        // I have removed all the non-parenthesis from this array.
        let parens_ints = 
            input.ToCharArray()
                |> List.map(fun x -> if x = '(' then 1 
                                    elif x = ')' then -1
                                    else 0)
                |> Seq.filter(fun x -> x <> 0)

        let rec calc (parens_ints:List<int>) count cur_ind = 
            if count < 0 then
                count
            elif cur_ind > parens_ints.Length then
                count
            else
                calc parens_ints (count + parens_ints.[cur_ind]) (cur_ind + 1)
    
        calc parens_ints 0 0