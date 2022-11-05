(* Declare a recursive function f: int -> int, where
f(n) = 1 + 2 + ... + (n - 1) + n for n >= 0  *)

module Ch1P4

let rec f = function
    | 0 -> 0
    | n -> n + f (n - 1)

let g = f 4

printf "%i" g // 10