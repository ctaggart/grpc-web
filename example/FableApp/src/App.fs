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

open Fable.Import.BookServicePb
let getBook() =
    printfn "started getBook"
    let getBookRequest = GetBookRequest()
    getBookRequest.setIsbn(60929871.) // TODO why a float
    // TODO need to import grpc-web-client
    let req = GetBookRequest()
    let options = grpc.UnaryRpcOptions(request = req, host = host, onEnd = fun res -> printfn "get book response")
    grpc.Globals.unary(BookService.GetBook, options)
    printfn "finished getBook"
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