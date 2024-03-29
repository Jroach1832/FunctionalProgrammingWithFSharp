﻿(*Declare a function f: int -> bool such that f(n) = true 
exactly when n is divisible by 2 or divisible by 3, but
not divisible by 5. Write down the expected values of 
f(24), f(27), f(29), and f(30) and compare with the result.*)

let f n = ((n % 2 = 0) || (n % 3 = 0)) && (n % 5 <> 0)

printf "%b\n" (f 24)
printf "%b\n" (f 27)
printf "%b\n" (f 29)
