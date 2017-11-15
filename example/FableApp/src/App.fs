module FableApp

open Fable.Core.JsInterop

let host = "http://127.0.0.1:9090"

let getBook() =
    printfn "started getBook"

    let pb: book_service_pb.IExports = importAll "../../ts/_proto/examplecom/library/book_service_pb"
    
    let rpc: grpc.grpc.IExports = import "grpc" "grpc-web-client"
    
    let getBookRequest = pb.GetBookRequest.Create()

    getBookRequest.setIsbn 60929871. // TODO why a float
    printfn "getBookRequest %A" getBookRequest

    let options = jsOptions<grpc.grpc.UnaryRpcOptions>(fun o ->
        o.request <- getBookRequest
        o.host <- host
        o.onEnd <- (fun output ->
            printfn "output: %A" output
        )
    )

    // let service: book_service_pb_service.BookService.IExports = importAll "../../ts/_proto/examplecom/library/book_service_pb"
    // info is added as a static class in TypeScript, but not sure how to use that from FSharp
    let method =
        createObj [
            "methodName" ==> "GetBook"
            "service" ==> createObj [ "serviceName" ==> "examplecom.library.BookService" ]
            "requestStream" ==> false
            "responseStream" ==> false
            "requestType" ==> pb.GetBookRequest
            "responseType" ==> pb.Book
        ]
    
    rpc.unary (method, options)

getBook()