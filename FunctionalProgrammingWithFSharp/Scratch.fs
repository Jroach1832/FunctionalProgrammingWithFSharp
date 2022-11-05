module Scratch

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

(* Recursive power function *)

let rec power = function
    | (x, 0) -> 1.0
    | (x, n) -> x * power (x, n - 1)

let d = power (2, 8)

printfn "%f" d

(* Recursive gcd function *)

let rec gcd = function
    | (0, n) -> n
    | (m, n) -> gcd(n % m, m)

let e = gcd (36, 116)

printfn "%i" e