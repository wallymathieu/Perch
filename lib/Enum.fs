﻿namespace Perch
open System
open System.Linq

    module Enum=
        let tryParse s :'a option when 'a:enum<'b> =
            match System.Enum.TryParse (s, true) with
            | true, v -> Some v
            | _ -> None
        
        let parse v =
            tryParse(v).Value

        let getValues<'t> ()= 
            let values = System.Enum.GetValues (typeof<'t>) 
            Enumerable.Cast<'t> values //Array.unbox