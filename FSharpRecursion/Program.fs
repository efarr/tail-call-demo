open System

[<EntryPoint>]
let main argv =
    let fib n =
        let rec rfib i p2 p1 =
            if i = n then p1
            else rfib (i+1) p1 (p2+p1)
        rfib 1 0 1
    fib 100000