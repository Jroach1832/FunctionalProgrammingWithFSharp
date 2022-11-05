(* Declare a function g: int -> int, where g(n) = n + 4 *)
module Ch1P1

let g = function
    | n -> ( n + 4 )

let h = g 5 

printf "%i" h // Output: 9
