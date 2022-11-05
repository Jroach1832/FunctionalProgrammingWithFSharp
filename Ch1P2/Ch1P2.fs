(* Declare a function h: float -> float, where
h(x, y) = sqrt(x^2 + y^2) *)

module Ch1P2

open System

let h = function
    | (0.0, 0.0) -> 0.0
    | (x, y) -> Math.Sqrt(x**2.0 + y**2.0)

let i = h (2.0, 2.0)

printfn "%f" i // ~2.83