(*Declare the F# function occInString: string * char -> int
where occInString(str, ch) = the number of occurrences of character ch
in the string str*)

let i = 0

let rec occInString (str :string) (ch :char) =
    match i with 
    | _ when i >= String.length str -> 0
    | _ when str.[i] = ch -> 1 + occInString (str.Substring (i + 1)) ch
    | _ -> occInString (str.Substring (i + 1)) ch

let s = """Lorem ipsum dolor sit amet, 
           consectetur adipiscing elit, 
           sed do eiusmod tempor incididunt 
           ut labore et dolore magna aliqua."""

printf "%i" (occInString s 'e')