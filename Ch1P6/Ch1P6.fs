(* Declare a recursive function sum: int * int -> int, where
sum(m, n) = m + (m + 1) + (m + 2) + ... + (m + (n - 1)) + (m + n)
for m >= 0 and n >= 0 *)

module Ch1P6

let rec sum = function
    | (m, 0) -> m
    | (m, n) -> n + m + sum (m, n - 1)

let a = sum (2, 2)

printf "%i" a // 9