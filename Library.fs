namespace DNNE_Sample

open System
open System.Runtime.CompilerServices
open System.Runtime.InteropServices
open DNNE

#nowarn "202" // The warning says UnmanagedCallersOnly isn't supported but it seems to work without issues in this scenario

module Exports =

    [<UnmanagedCallersOnly(CallConvs = [| typeof<CallConvStdcall> |])>]
    let AddOne (x: int):int = x + 1

