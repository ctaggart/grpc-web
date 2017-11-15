module rec grpc
open System
open Fable.Core
open Fable.Import.JS

module grpc =

    type [<AllowNullLiteral>] IExports =
        abstract ProtobufMessageClass: ProtobufMessageClassStatic with get, set
        // abstract unary: methodDescriptor: 'M * props: UnaryRpcOptions <'M, 'TRequest, 'TResponse> -> unit
        abstract unary: methodDescriptor: obj * props: UnaryRpcOptions -> unit
        abstract invoke: methodDescriptor: 'M * props: RpcOptions<'TRequest, 'TResponse> -> unit
        abstract UnaryRpcOptions: UnaryRpcOptionsStatic with get, set

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

//   export type UnaryMethodDefinition<TRequest extends jspb.Message, TResponse extends jspb.Message> = MethodDefinition<TRequest, TResponse> & {
//     responseStream: false;
//   }

    // type UnaryMethodDefinition<'TRequest, 'TResponse> =
    // type UnaryMethodDefinition<'TRequest, 'TResponse when 'TRequest :> protobuf.Message and 'TResponse :> protobuf.Message> =
    //     inherit MethodDefinition<'TRequest, 'TResponse>
    //     abstract responseStream: bool with get, set
        // obj
        // interface end
    [<AllowNullLiteral>]
    type UnaryMethodDefinition =
        interface end

    type RpcOptions<'TRequest, 'TResponse> =
        // obj
        interface end

    type UnaryOutput<'TResponse> =
        // obj
        interface end

//   export type UnaryRpcOptions<M extends UnaryMethodDefinition<TRequest, TResponse>, TRequest extends jspb.Message, TResponse extends jspb.Message> = {
//     host: string,
//     request: TRequest,
//     metadata?: Metadata.ConstructorArg,
//     onEnd: (output: UnaryOutput<TResponse>) => void,
//     transport?: Transport,
//     debug?: boolean,
//   }

    // type UnaryRpcOptions<'M, 'TRequest, 'TResponse when 'M :> UnaryMethodDefinition<'TRequest, 'TResponse> and 'TRequest :> protobuf.Message and 'TResponse :> protobuf.Message> =
    // type UnaryRpcOptions<'M, 'TRequest, 'TResponse when 'M :> UnaryMethodDefinition and 'TRequest :> protobuf.Message and 'TResponse :> protobuf.Message> =
    type UnaryRpcOptions =
        abstract host: string with get, set
        abstract request: 'TRequest with get, set

    type [<AllowNullLiteral>] UnaryRpcOptionsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UnaryRpcOptions //<'M, 'TRequest, 'TResponse>