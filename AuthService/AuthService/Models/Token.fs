module Token

open System

type Token = 
    | Token of string 
    | Expiration of DateTime  