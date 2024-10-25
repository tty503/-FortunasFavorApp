module User

type User =
    | Id of int
    | Username of string 
    | Password of string
    | Claims of list<string>