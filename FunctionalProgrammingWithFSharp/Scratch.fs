(* Area of a circle with radius r *)

let circleArea r = System.Math.PI * r * r

let a = circleArea 1.0

printfn "%f" a

(* Lookup function for days in a month *)

let daysOfMonth = function
    | 2 -> 28
    | 4 | 6 | 9 | 11 -> 30
    | _ -> 31

let b = daysOfMonth 4

printfn "%i" b

(* Recursive factorial function *)

let rec fact = function
    | 0 -> 1
    | n -> n * fact (n - 1)

let c = fact 4

printfn "%i" c
