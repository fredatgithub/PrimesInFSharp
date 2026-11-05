printfn "Prime calculation in F#"
printfn " "
// Calcul de nombres premiers

let estPremier n =
    if n < 2 then
        false
    else
        [2 .. int (sqrt (float n))]
        |> List.forall (fun i -> n % i <> 0)

let nombreMax = 500

let premiers =
    [2 .. nombreMax]
    |> List.filter estPremier

printfn "Nombres premiers : %A" premiers
