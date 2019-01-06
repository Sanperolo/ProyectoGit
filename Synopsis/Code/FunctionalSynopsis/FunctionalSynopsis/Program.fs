open System
open System.IO

File.WriteAllText("C:\Users\Mi PC\workspaceFP\FunctionalSynopsis\FunctionalSynopsis\Prueba\SynopsisFile.txt","This is a default message -> FUNCTIONAL IS LOVE")

let str = File.ReadAllText(@"C:\Users\Mi PC\workspaceFP\FunctionalSynopsis\FunctionalSynopsis\Prueba\SynopsisFile.txt")

printfn "%A" str

let vocals = ['a';'e';'i';'o';'u';'A';'E';'I';'O';'U']

let isVocals =
    fun count -> vocals |> List.contains count

let vCount =
    String.filter isVocals
    >> String.length

printfn "VOCALS -> %A" (vCount str)