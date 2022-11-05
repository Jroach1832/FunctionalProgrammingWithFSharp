(* The sequence F0, F1, F2, ... of Fibonacci numbers is defined by

F0 = 0
F1 = 1
Fn = Fn-1 + Fn-2

Thus, the first members of the sequence are 0, 1, 1, 2, 3, 5, 8, 13, ...
Declare a function to compute Fn.*)

module Ch1P5

let rec f = function
    | 0 -> 0
    | 1 -> 1
    | n -> f (n - 1) + f (n - 2)

let g = f 4

printf "%i" g // 3
