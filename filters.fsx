// module FiltersModule

type StringOperation = 
    | Contains
    | DoesNotContain
    | StartsWith
    | EndsWith
    | Equals
    | DoesNotEqual

type NumericOperation =
    | Equals
    | DoesNotEqual
    | GreaterThan
    | GreaterThanOrEqual
    | LessThan
    | LessThanOrEqual
 
type MultiSelectionFilter = MultiSelectionFilter of string list

type OperationalFilter = 
    | StringFilter of op : StringOperation * value : string
    | NumericFilter of op : NumericOperation * value : float
    | BetweenFilter of left : float * right : float

let multi = MultiSelectionFilter(["a"; "b"; "c"; "d"])
let multiFilter = ["a"; "b"; "c"; "d"] |> MultiSelectionFilter
let opFilter = StringFilter(Contains, "064075")
let opFilter2 = NumericFilter(GreaterThanOrEqual, 5.5)
let opFilter3 = BetweenFilter(12., 20.)
