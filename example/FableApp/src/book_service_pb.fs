module rec book_service_pb
open System
open Fable.Core
open Fable.Import.JS

module jspb = protobuf

type [<AllowNullLiteral>] IExports =
    abstract Book: BookStatic with get, set
    abstract GetBookRequest: GetBookRequestStatic with get, set
    abstract QueryBooksRequest: QueryBooksRequestStatic with get, set

type [<AllowNullLiteral>] Book =
    inherit jspb.Message
    abstract getIsbn: unit -> float
    abstract setIsbn: value: float -> unit
    abstract getTitle: unit -> string
    abstract setTitle: value: string -> unit
    abstract getAuthor: unit -> string
    abstract setAuthor: value: string -> unit
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> Book.AsObject
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] BookStatic =
    abstract toObject: includeInstance: bool * msg: Book -> Book.AsObject
    abstract serializeBinaryToWriter: message: Book * writer: jspb.BinaryWriter -> unit
    abstract deserializeBinary: bytes: Uint8Array -> Book
    abstract deserializeBinaryFromReader: message: Book * reader: jspb.BinaryReader -> Book

module Book =

    type AsObject =
        obj

type [<AllowNullLiteral>] GetBookRequest =
    inherit jspb.Message
    abstract getIsbn: unit -> float
    abstract setIsbn: value: float -> unit
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> GetBookRequest.AsObject
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] GetBookRequestStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> GetBookRequest
    abstract toObject: includeInstance: bool * msg: GetBookRequest -> GetBookRequest.AsObject
    abstract serializeBinaryToWriter: message: GetBookRequest * writer: jspb.BinaryWriter -> unit
    abstract deserializeBinary: bytes: Uint8Array -> GetBookRequest
    abstract deserializeBinaryFromReader: message: GetBookRequest * reader: jspb.BinaryReader -> GetBookRequest

module GetBookRequest =

    type AsObject =
        obj

type [<AllowNullLiteral>] QueryBooksRequest =
    inherit jspb.Message
    abstract getAuthorPrefix: unit -> string
    abstract setAuthorPrefix: value: string -> unit
    abstract serializeBinary: unit -> Uint8Array
    abstract toObject: ?includeInstance: bool -> QueryBooksRequest.AsObject
    abstract extensions: obj with get, set
    abstract extensionsBinary: obj with get, set

type [<AllowNullLiteral>] QueryBooksRequestStatic =
    abstract toObject: includeInstance: bool * msg: QueryBooksRequest -> QueryBooksRequest.AsObject
    abstract serializeBinaryToWriter: message: QueryBooksRequest * writer: jspb.BinaryWriter -> unit
    abstract deserializeBinary: bytes: Uint8Array -> QueryBooksRequest
    abstract deserializeBinaryFromReader: message: QueryBooksRequest * reader: jspb.BinaryReader -> QueryBooksRequest

module QueryBooksRequest =

    type AsObject =
        obj
