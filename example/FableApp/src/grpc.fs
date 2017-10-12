namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

module grpc =
    type [<AllowNullLiteral>] ProtobufMessageClass<'T> =
        [<Emit("new $0($1...)")>] abstract Create: unit -> 'T
        abstract deserializeBinary: bytes: Uint8Array -> 'T

    and [<AllowNullLiteral>] ServiceDefinition =
        abstract serviceName: string with get, set

    and [<AllowNullLiteral>] MethodDefinition<'TRequest, 'TResponse> =
        abstract methodName: string with get, set
        abstract service: ServiceDefinition with get, set
        abstract requestStream: bool with get, set
        abstract responseStream: bool with get, set
        abstract requestType: ProtobufMessageClass<'TRequest> with get, set
        abstract responseType: ProtobufMessageClass<'TResponse> with get, set

    // and [<AllowNullLiteral>] UnaryMethodDefinition<'TRequest, 'TResponse> =
    //     obj
    and UnaryMethodDefinition<'TRequest, 'TResponse> = U2<'TRequest, 'TResponse>

    // and [<AllowNullLiteral>] RpcOptions<'TRequest, 'TResponse> =
    //     obj
    and RpcOptions<'TRequest, 'TResponse> = U2<'TRequest, 'TResponse>

    // and [<AllowNullLiteral>] UnaryOutput<'TResponse> =
    //     obj
    // and UnaryOutput<'TResponse> = U2<'TResponse>

    // type UnaryOutput<TResponse> = {
    //     status: Code;
    //     statusMessage: string;
    //     headers: Metadata;
    //     message: TResponse | null;
    //     trailers: Metadata;
    // };
    and [<AllowNullLiteral>] UnaryOutput<'TResponse> =
        // abstract status: Code with get, set
        abstract statusMessage: string with get, set
        abstract message: 'TResponse option with get, set


    // and [<AllowNullLiteral>] UnaryRpcOptions<'M, 'TRequest, 'TResponse> =
    //     obj

    // TODO missing a lot from the .ts file

    // type UnaryRpcOptions<M extends UnaryMethodDefinition<TRequest, TResponse>, TRequest extends jspb.Message, TResponse extends jspb.Message> = {
    //     host: string;
    //     request: TRequest;
    //     metadata?: Metadata.ConstructorArg;
    //     onEnd: (output: UnaryOutput<TResponse>) => void;
    //     transport?: Transport;
    //     debug?: boolean;
    // };

    // and [<AllowNullLiteral>] UnaryRpcOptions<'M, 'TRequest, 'TResponse> =
    //     abstract host: string with get, set
    //     abstract request: 'TRequest with get, set
    //     abstract onEnd: UnaryOutput<'TResponse> -> unit with get, set

    and [<AllowNullLiteral>] UnaryRpcOptions<'M, 'TRequest, 'TResponse>() =
        member __.host with get(): string = jsNative and set(v: string): unit = jsNative
        member __.request with get(): 'TRequest = jsNative and set(v: 'TRequest): unit = jsNative
        member __.onEnd with get(): UnaryOutput<'TResponse> -> unit = jsNative and set(v: UnaryOutput<'TResponse> -> unit): unit = jsNative

    type [<Import("*","grpc")>] Globals =
        static member unary(methodDescriptor: 'M, props: UnaryRpcOptions<'M, 'TRequest, 'TResponse>): unit = jsNative
        static member invoke(methodDescriptor: 'M, props: RpcOptions<'TRequest, 'TResponse>): unit = jsNative


