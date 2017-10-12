namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] [<Import("*","BookService")>] BookService() =
    member __.serviceName with get(): obj = jsNative and set(v: obj): unit = jsNative

module BookService =
    type [<AllowNullLiteral>] [<Import("GetBook","BookService")>] GetBook() =
        member __.methodName with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.service with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.requestStream with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.responseStream with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.requestType with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.responseType with get(): obj = jsNative and set(v: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("QueryBooks","BookService")>] QueryBooks() =
        member __.methodName with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.service with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.requestStream with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.responseStream with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.requestType with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.responseType with get(): obj = jsNative and set(v: obj): unit = jsNative


