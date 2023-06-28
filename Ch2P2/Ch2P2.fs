(*Declare an F# function pow: string * int -> string, where
pow(s, n) = s*s*...*s, where we use * to denote string
concatenation *)

let rec pow = function
    | (a, 0) -> ""
    | (a, b) -> a + pow (a, b - 1)

printf "%s\n" (pow ("s", 1))
printf "%s\n" (pow ("s", 2))
printf "%s\n" (pow ("s", 3))
printf "%s\n" (pow ("s", 4))
printf "%s\n" (pow ("s", 5))
