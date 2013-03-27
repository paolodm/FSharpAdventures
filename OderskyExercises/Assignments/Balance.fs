module Assignment2

    let (|Prefix|_|) (p:string) (s:string) =
        if s.StartsWith(p) then
            Some(s.Substring(p.Length))
        else
            None

    let balance (chars:string) = 
        let rec calc remaining acc =
            if acc > 1 || acc < -1 then
                false
         
            match (chars, acc) with
            | (_, 2) -> false
            | (_, -1) -> false
            | ("", _) -> true
            | (Prefix "(" rest, _) -> calc rest (acc - 1)
            | (Prefix ")" rest, _) -> calc rest (acc + 1)
            | (_, _) -> calc Some(rest.Substring(1)) acc

        calc chars 0