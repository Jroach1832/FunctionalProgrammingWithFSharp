(*Declare the F# function isIthChar: string*int*char -> bool
where the value of isIthChar(str, i, ch) is true if and only
if ch is the i'th character in the string str (numbering
starting at 0)*)

let isIthChar (str :string) (i :int) (ch :char) = 
    if i > 0 && i < String.length str then
        str.[i] = ch
    else
        false

printf "%b\n" (isIthChar "Hello" 0 'H')
printf "%b\n" (isIthChar "Hello" 2 'o')
printf "%b\n" (isIthChar "Hello" 4 'o')


