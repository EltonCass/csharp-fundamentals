namespace MergeSortExample
open Microsoft.FSharp.Collections

module MergeSort =
   
    let fsharpList csharpList = List.ofSeq(csharpList)

    // Define the merge function
    let rec merge left right =
        match left, right with
        | [], rightList -> rightList
        | leftList, [] -> leftList
        | leftHead :: leftTail, rightHead :: rightTail ->
            if leftHead <= rightHead then
                leftHead :: merge leftTail right
            else
                rightHead :: merge left rightTail

    // Define the mergeSort function
    let rec mergeSort list =
        let length = List.length list
        if length <= 1 then
            list
        else
            let middle = length / 2
            let left = List.take middle list
            let right = List.skip middle list
            let sortedLeft = mergeSort left
            let sortedRight = mergeSort right
            merge sortedLeft sortedRight
