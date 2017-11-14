module rec book_service_pb_service
open System
open Fable.Core
open Fable.Import.JS

type TODO = obj

type [<AllowNullLiteral>] BookService =
    abstract serviceName: TODO with get, set

module BookService =

    type [<AllowNullLiteral>] GetBook =
        abstract methodName: TODO with get, set
        abstract service: TODO with get, set
        abstract requestStream: TODO with get, set
        abstract responseStream: TODO with get, set
        abstract requestType: TODO with get, set
        abstract responseType: TODO with get, set

    type [<AllowNullLiteral>] QueryBooks =
        abstract methodName: TODO with get, set
        abstract service: TODO with get, set
        abstract requestStream: TODO with get, set
        abstract responseStream: TODO with get, set
        abstract requestType: TODO with get, set
        abstract responseType: TODO with get, set
