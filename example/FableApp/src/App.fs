module FableApp

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

// function getBook() {
//   const getBookRequest = new GetBookRequest();
//   getBookRequest.setIsbn(60929871);
//   grpc.unary(BookService.GetBook, {
//     request: getBookRequest,
//     host: host,
//     onEnd: res => {
//       const { status, statusMessage, headers, message, trailers } = res;
//       console.log("getBook.onEnd.status", status, statusMessage);
//       console.log("getBook.onEnd.headers", headers);
//       if (status === Code.OK && message) {
//         console.log("getBook.onEnd.message", message.toObject());
//       }
//       console.log("getBook.onEnd.trailers", trailers);
//       queryBooks();
//     }
//   });
// }

let host = "https://localhost:9091"

// open BookServicePb
// open book_service_pb
// open book_service_pb_service

// import {QueryBooksRequest, Book, GetBookRequest} from "../_proto/examplecom/library/book_service_pb";


let getBook() =
    printfn "started getBook"
    // let getBookRequest = GetBookRequest()

    // let getBookRequest: book_service_pb.GetBookRequest = import "GetBookRequest" "../../ts/_proto/examplecom/library/book_service_pb" // .js

    let pb: book_service_pb.IExports = importAll "../../ts/_proto/examplecom/library/book_service_pb" // .js
    let service: book_service_pb_service.BookService.IExports = importAll "../../ts/_proto/examplecom/library/book_service_pb"
    
    let getBookRequest = pb.GetBookRequest.Create()

    getBookRequest.setIsbn(60929871.) // TODO why a float
    printfn "getBookRequest %A" getBookRequest

    // let rpc: grpc.grpc.IExports = importAll "grpc-web-client/dist/grpc"
    // import {grpc, Code, Metadata} from "grpc-web-client";
    let rpc: grpc.grpc.IExports = import "grpc" "grpc-web-client"

    // let options = rpc.UnaryRpcOptions.Create() // rpc.UnaryRpcOptions is not a constructor
    let options = jsOptions<grpc.grpc.UnaryRpcOptions>(fun o ->
        o.request <- getBookRequest
        o.host <- host
    )

    // let method = service.GetBook
    let method =
        createObj [
            "methodName" ==> "GetBook"
            "service" ==> createObj [ "serviceName" ==> "examplecom.library.BookService" ]
            "requestStream" ==> false
            "responseStream" ==> false
            "requestType" ==> "examplecom_library_book_service_pb.GetBookRequest"
            "responseType" ==> "examplecom_library_book_service_pb.Book"
        ]
    // options.onEnd <- fun res -> printfn "got book response"

    // let method = service.GetBook.Create()
    
    rpc.unary (method, options)


    // TODO need to import grpc-web-client
    // let req = GetBookRequest()
    // let options = grpc.UnaryRpcOptions(request = req, host = host, onEnd = fun res -> printfn "get book response")
    // grpc.Globals.unary(BookService.GetBook, options)
    // printfn "finished getBook"
    ()


let init() =
    // let canvas = Browser.document.getElementsByTagName_canvas().[0]
    // canvas.width <- 1000.
    // canvas.height <- 800.
    // let ctx = canvas.getContext_2d()
    // // The (!^) operator checks and casts a value to an Erased Union type
    // // See http://fable.io/docs/interacting.html#Erase-attribute
    // ctx.fillStyle <- !^"rgb(200,0,0)"
    // ctx.fillRect (10., 10., 55., 50.)
    // ctx.fillStyle <- !^"rgba(0, 0, 200, 0.5)"
    // ctx.fillRect (30., 30., 55., 50.)
    printfn "init"
    getBook()

init()