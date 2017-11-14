module rec grpc
open System
open Fable.Core
open Fable.Import.JS

module grpc =

    type [<AllowNullLiteral>] IExports =
        abstract ProtobufMessageClass: ProtobufMessageClassStatic with get, set
        abstract unary: methodDescriptor: 'M * props: UnaryRpcOptions<'M, 'TRequest, 'TResponse> -> unit
        abstract invoke: methodDescriptor: 'M * props: RpcOptions<'TRequest, 'TResponse> -> unit

    type [<AllowNullLiteral>] ProtobufMessageClass<'T> =
        abstract deserializeBinary: bytes: Uint8Array -> 'T

    type [<AllowNullLiteral>] ProtobufMessageClassStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ProtobufMessageClass<'T>

    type [<AllowNullLiteral>] ServiceDefinition =
        abstract serviceName: string with get, set

    type [<AllowNullLiteral>] MethodDefinition<'TRequest, 'TResponse> =
        abstract methodName: string with get, set
        abstract service: ServiceDefinition with get, set
        abstract requestStream: bool with get, set
        abstract responseStream: bool with get, set
        abstract requestType: ProtobufMessageClass<'TRequest> with get, set
        abstract responseType: ProtobufMessageClass<'TResponse> with get, set

    type UnaryMethodDefinition<'TRequest, 'TResponse> =
        // obj
        interface end

    type RpcOptions<'TRequest, 'TResponse> =
        // obj
        interface end

    type UnaryOutput<'TResponse> =
        // obj
        interface end

    type UnaryRpcOptions<'M, 'TRequest, 'TResponse> =
        // obj
        interface end
