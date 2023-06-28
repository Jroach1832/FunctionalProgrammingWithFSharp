(*Declare the F# function occFromIth: string * int * char -> int 
where occFromIth(str, i, ch) = the number of occurrences of character
ch in positions j in the string str with j >= i*)

let rec occFromIth (str :string) (i :int) (ch :char) =
    match i with 
    | _ when i >= String.length str -> 0
    | _ when str.[i] = ch -> 1 + occFromIth str (i + 1) ch
    | _ -> occFromIth str (i + 1) ch
    
let str = "Hello, world!"
let charToCount = 'o'
let startIndex = 3
let occurrences = occFromIth str startIndex charToCount

printfn "Number of occurrences of '%c' from index %d onwards: %d" charToCount startIndex occurrences