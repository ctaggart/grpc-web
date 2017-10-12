namespace rec Fable.Import.BookServicePb
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] Book() =
    inherit Fable.Import.Google.Protobuf.Message()
    member __.extensions with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.extensionsBinary with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.getIsbn(): float = jsNative
    member __.setIsbn(value: float): unit = jsNative
    member __.getTitle(): string = jsNative
    member __.setTitle(value: string): unit = jsNative
    member __.getAuthor(): string = jsNative
    member __.setAuthor(value: string): unit = jsNative
    member __.serializeBinary(): Uint8Array = jsNative
    member __.toObject(?includeInstance: bool): Book.AsObject = jsNative
    static member toObject(includeInstance: bool, msg: Book): Book.AsObject = jsNative
    static member serializeBinaryToWriter(message: Book, writer: Fable.Import.Google.Protobuf.BinaryWriter): unit = jsNative
    static member deserializeBinary(bytes: Uint8Array): Book = jsNative
    static member deserializeBinaryFromReader(message: Book, reader: Fable.Import.Google.Protobuf.BinaryReader): Book = jsNative

and [<AllowNullLiteral>] GetBookRequest() =
    inherit Fable.Import.Google.Protobuf.Message()
    member __.extensions with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.extensionsBinary with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.getIsbn(): float = jsNative
    member __.setIsbn(value: float): unit = jsNative
    member __.serializeBinary(): Uint8Array = jsNative
    member __.toObject(?includeInstance: bool): GetBookRequest.AsObject = jsNative
    static member toObject(includeInstance: bool, msg: GetBookRequest): GetBookRequest.AsObject = jsNative
    static member serializeBinaryToWriter(message: GetBookRequest, writer: Fable.Import.Google.Protobuf.BinaryWriter): unit = jsNative
    static member deserializeBinary(bytes: Uint8Array): GetBookRequest = jsNative
    static member deserializeBinaryFromReader(message: GetBookRequest, reader: Fable.Import.Google.Protobuf.BinaryReader): GetBookRequest = jsNative

and [<AllowNullLiteral>] QueryBooksRequest() =
    inherit Fable.Import.Google.Protobuf.Message()
    member __.extensions with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.extensionsBinary with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.getAuthorPrefix(): string = jsNative
    member __.setAuthorPrefix(value: string): unit = jsNative
    member __.serializeBinary(): Uint8Array = jsNative
    member __.toObject(?includeInstance: bool): QueryBooksRequest.AsObject = jsNative
    static member toObject(includeInstance: bool, msg: QueryBooksRequest): QueryBooksRequest.AsObject = jsNative
    static member serializeBinaryToWriter(message: QueryBooksRequest, writer: Fable.Import.Google.Protobuf.BinaryWriter): unit = jsNative
    static member deserializeBinary(bytes: Uint8Array): QueryBooksRequest = jsNative
    static member deserializeBinaryFromReader(message: QueryBooksRequest, reader: Fable.Import.Google.Protobuf.BinaryReader): QueryBooksRequest = jsNative

module Book =
    type AsObject =
        obj



module GetBookRequest =
    type AsObject =
        obj



module QueryBooksRequest =
    type AsObject =
        obj


