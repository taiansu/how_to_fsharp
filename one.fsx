// Simple
let s:string = "Hello World";
let i:int = 42;
let d:decimal = 3.14159m;

// unit -> nothing

// Complex

// Record type
// define a type
type Person = {
  Name:string
  Birth:System.DateTime
}

// create an instance of the type
let devon = {
  Name = "Devon"
  Birth = System.DateTime.Parse("2121/01/01")
}

let devonBurriss = { devon with Name = "Devon Burriss" }

// Tuple
let myTuple = (true,99)
let n1 = myTuple |> snd
let (b,n) = myTuple // pattern matching

// Collections
// List, Array and Seq

