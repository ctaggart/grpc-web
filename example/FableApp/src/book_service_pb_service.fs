module rec book_service_pb_service
open System
open Fable.Core
open Fable.Import.JS

type TODO = obj

type [<AllowNullLiteral>] BookService =
    abstract serviceName: TODO with get, set

module BookService =

    type [<AllowNullLiteral>] IExports =
        abstract GetBook: GetBookStatic with get, set

//   export class GetBook {
//     static readonly methodName = "GetBook";
//     static readonly service = BookService;
//     static readonly requestStream = false;
//     static readonly responseStream = false;
//     static readonly requestType = examplecom_library_book_service_pb.GetBookRequest;
//     static readonly responseType = examplecom_library_book_service_pb.Book;
//   }

    type [<AllowNullLiteral>] GetBook =
        inherit grpc.grpc.UnaryMethodDefinition
        // abstract methodName: TODO with get, set
        // abstract service: TODO with get, set
        // abstract requestStream: TODO with get, set
        // abstract responseStream: TODO with get, set
        // abstract requestType: TODO with get, set
        abstract responseType: TODO with get, set
        // interface end

    type [<AllowNullLiteral>] GetBookStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GetBook
        // abstract methodName: string
        // abstract service: BookService

    type [<AllowNullLiteral>] QueryBooks =
        abstract methodName: TODO with get, set
        abstract service: TODO with get, set
        abstract requestStream: TODO with get, set
        abstract responseStream: TODO with get, set
        abstract requestType: TODO with get, set
        abstract responseType: TODO with get, set
