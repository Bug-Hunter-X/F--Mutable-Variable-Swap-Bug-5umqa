let swap (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable x = ref 10
let mutable y = ref 20
swap x y
printf "%d %d" x.Value y.Value // This will correctly print 20 10