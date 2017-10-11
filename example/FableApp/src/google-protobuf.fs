namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] ByteSource =
    U4<ArrayBuffer, Uint8Array, ResizeArray<float>, string>

and [<AllowNullLiteral>] ScalarFieldType =
    U3<bool, float, string>

and [<AllowNullLiteral>] RepeatedFieldType =
    U2<ResizeArray<ScalarFieldType>, ResizeArray<Uint8Array>>

and [<AllowNullLiteral>] AnyFieldType =
    U3<ScalarFieldType, RepeatedFieldType, Uint8Array>

and [<AllowNullLiteral>] FieldValue =
    obj

and [<AllowNullLiteral>] FieldValueArray =
    inherit ResizeArray<FieldValue>


and [<AllowNullLiteral>] [<Import("*","Message")>] Message() =
    member __.``null`` with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.extensions with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.extensionsBinary with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.getJsPbMessageId(): U2<string, undefined> = jsNative
    static member initialize(msg: Message, data: Message.MessageArray, messageId: U2<string, float>, suggestedPivot: float, ?repeatedFields: ResizeArray<float>, ?oneofFields: U2<ResizeArray<ResizeArray<float>>, obj>): unit = jsNative
    static member toObjectList(field: ResizeArray<'T>, toObjectFn: Func<bool, 'T, obj>, ?includeInstance: bool): ResizeArray<obj> = jsNative
    static member toObjectExtension(msg: Message, obj: obj, extensions: obj, getExtensionFn: Func<ExtensionFieldInfo<Message>, Message>, ?includeInstance: bool): unit = jsNative
    member __.serializeBinaryExtensions(proto: Message, writer: BinaryWriter, extensions: obj, getExtensionFn: Func<ExtensionFieldInfo<'T>, 'T>): unit = jsNative
    member __.readBinaryExtension(proto: Message, reader: BinaryReader, extensions: obj, setExtensionFn: Func<ExtensionFieldInfo<'T>, 'T, unit>): unit = jsNative
    static member getField(msg: Message, fieldNumber: float): U2<FieldValue, obj> = jsNative
    static member getOptionalFloatingPointField(msg: Message, fieldNumber: float): U2<float, undefined> = jsNative
    static member getRepeatedFloatingPointField(msg: Message, fieldNumber: float): ResizeArray<float> = jsNative
    static member bytesAsB64(bytes: Uint8Array): string = jsNative
    static member bytesAsU8(str: string): Uint8Array = jsNative
    static member bytesListAsB64(bytesList: ResizeArray<Uint8Array>): ResizeArray<string> = jsNative
    static member bytesListAsU8(strList: ResizeArray<string>): ResizeArray<Uint8Array> = jsNative
    static member getFieldWithDefault(msg: Message, fieldNumber: float, defaultValue: 'T): 'T = jsNative
    static member getMapField(msg: Message, fieldNumber: float, noLazyCreate: bool, valueCtor: obj): Map<obj, obj> = jsNative
    static member setField(msg: Message, fieldNumber: float, value: FieldValue): unit = jsNative
    static member addToRepeatedField(msg: Message, fieldNumber: float, value: obj, ?index: float): unit = jsNative
    static member setOneofField(msg: Message, fieldNumber: float, oneof: ResizeArray<float>, value: FieldValue): unit = jsNative
    static member computeOneofCase(msg: Message, oneof: ResizeArray<float>): float = jsNative
    static member getWrapperField(msg: Message, ctor: obj, fieldNumber: float, ?required: float): 'T = jsNative
    static member getRepeatedWrapperField(msg: Message, ctor: obj, fieldNumber: float): ResizeArray<'T> = jsNative
    static member setWrapperField(msg: Message, fieldNumber: float, ?value: U2<'T, Map<obj, obj>>): unit = jsNative
    static member setOneofWrapperField(msg: Message, fieldNumber: float, oneof: ResizeArray<float>, value: obj): unit = jsNative
    static member setRepeatedWrapperField(msg: Message, fieldNumber: float, ?value: ResizeArray<'T>): unit = jsNative
    static member addToRepeatedWrapperField(msg: Message, fieldNumber: float, value: U2<'T, undefined>, ctor: obj, ?index: float): 'T = jsNative
    static member toMap(field: ResizeArray<obj>, mapKeyGetterFn: Func<obj, string>, ?toObjectFn: Message.StaticToObject, ?includeInstance: bool): unit = jsNative
    member __.toArray(): Message.MessageArray = jsNative
    member __.toString(): string = jsNative
    member __.getExtension(fieldInfo: ExtensionFieldInfo<'T>): 'T = jsNative
    member __.setExtension(fieldInfo: ExtensionFieldInfo<'T>, value: 'T): unit = jsNative
    static member difference(m1: 'T, m2: 'T): 'T = jsNative
    static member equals(m1: Message, m2: Message): bool = jsNative
    static member compareExtensions(extension1: obj, extension2: obj): bool = jsNative
    static member compareFields(field1: obj, field2: obj): bool = jsNative
    member __.cloneMessage(): Message = jsNative
    member __.clone(): Message = jsNative
    static member clone(msg: 'T): 'T = jsNative
    static member cloneMessage(msg: 'T): 'T = jsNative
    static member copyInto(fromMessage: Message, toMessage: Message): unit = jsNative
    static member registerMessageType(id: float, ``constructor``: obj): unit = jsNative
    member __.serializeBinary(): Uint8Array = jsNative
    member __.toObject(?includeInstance: bool): obj = jsNative
    static member deserializeBinary(bytes: Uint8Array): Message = jsNative
    static member deserializeBinaryFromReader(message: Message, reader: BinaryReader): Message = jsNative
    static member serializeBinaryToWriter(message: Message, writer: BinaryWriter): unit = jsNative
    static member toObject(includeInstance: bool, msg: Message): obj = jsNative

and [<AllowNullLiteral>] [<Import("*","ExtensionFieldInfo")>] ExtensionFieldInfo<'T>(fieldIndex: float, fieldName: obj, ctor: obj, toObjectFn: Message.StaticToObject, isRepeated: float) =
    member __.fieldIndex with get(): float = jsNative and set(v: float): unit = jsNative
    member __.fieldName with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ctor with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.toObjectFn with get(): Message.StaticToObject = jsNative and set(v: Message.StaticToObject): unit = jsNative
    member __.isRepeated with get(): float = jsNative and set(v: float): unit = jsNative
    member __.isMessageType(): bool = jsNative

and [<AllowNullLiteral>] [<Import("*","ExtensionFieldBinaryInfo")>] ExtensionFieldBinaryInfo<'T>(fieldInfo: ExtensionFieldInfo<'T>, binaryReaderFn: BinaryRead, binaryWriterFn: BinaryWrite, opt_binaryMessageSerializeFn: Func<Message, BinaryWriter, unit>, opt_binaryMessageDeserializeFn: Func<Message, BinaryReader, Message>, opt_isPacked: bool) =
    member __.fieldInfo with get(): ExtensionFieldInfo<'T> = jsNative and set(v: ExtensionFieldInfo<'T>): unit = jsNative
    member __.binaryReaderFn with get(): BinaryRead = jsNative and set(v: BinaryRead): unit = jsNative
    member __.binaryWriterFn with get(): BinaryWrite = jsNative and set(v: BinaryWrite): unit = jsNative
    member __.opt_binaryMessageSerializeFn with get(): Func<Message, BinaryWriter, unit> = jsNative and set(v: Func<Message, BinaryWriter, unit>): unit = jsNative
    member __.opt_binaryMessageDeserializeFn with get(): Func<Message, BinaryReader, Message> = jsNative and set(v: Func<Message, BinaryReader, Message>): unit = jsNative
    member __.opt_isPacked with get(): bool = jsNative and set(v: bool): unit = jsNative

and [<AllowNullLiteral>] [<Import("*","Map")>] Map<'K, 'V>(arr: ResizeArray<'K * 'V>, ?valueCtor: obj) =
    member __.toArray(): ResizeArray<'K * 'V> = jsNative
    member __.toObject(?includeInstance: bool): ResizeArray<'K * 'V> = jsNative
    member __.toObject(includeInstance: bool, valueToObject: Func<bool, 'V, 'VO>): ResizeArray<'K * 'VO> = jsNative
    static member fromObject(entries: ResizeArray<'TK * 'TV>, valueCtor: obj, valueFromObject: obj): Map<'TK, 'TV> = jsNative
    member __.getLength(): float = jsNative
    member __.clear(): unit = jsNative
    member __.del(key: 'K): bool = jsNative
    member __.getEntryList(): ResizeArray<'K * 'V> = jsNative
    member __.entries(): Map.Iterator<'K * 'V> = jsNative
    member __.keys(): Map.Iterator<'K> = jsNative
    member __.forEach(callback: Func<'V, 'K, unit>, ?thisArg: obj): unit = jsNative
    member __.set(key: 'K, value: 'V): obj = jsNative
    member __.get(key: 'K): U2<'V, undefined> = jsNative
    member __.has(key: 'K): bool = jsNative

and [<AllowNullLiteral>] BinaryReadReader =
    Func<obj, BinaryReader, unit>

and [<AllowNullLiteral>] BinaryRead =
    Func<obj, BinaryReadReader, unit>

and [<AllowNullLiteral>] BinaryWriteCallback =
    Func<obj, BinaryWriter, unit>

and [<AllowNullLiteral>] BinaryWrite =
    Func<float, obj, BinaryWriteCallback, unit>

and [<AllowNullLiteral>] [<Import("*","BinaryReader")>] BinaryReader(?bytes: ByteSource, ?start: float, ?length: float) =
    member __.readMessage with get(): BinaryRead = jsNative and set(v: BinaryRead): unit = jsNative
    static member alloc(?bytes: ByteSource, ?start: float, ?length: float): BinaryReader = jsNative
    member __.free(): unit = jsNative
    member __.getFieldCursor(): float = jsNative
    member __.getCursor(): float = jsNative
    member __.getBuffer(): Uint8Array = jsNative
    member __.getFieldNumber(): float = jsNative
    member __.getWireType(): BinaryConstants.WireType = jsNative
    member __.isEndGroup(): bool = jsNative
    member __.getError(): bool = jsNative
    member __.setBlock(?bytes: ByteSource, ?start: float, ?length: float): unit = jsNative
    member __.reset(): unit = jsNative
    member __.advance(count: float): unit = jsNative
    member __.nextField(): bool = jsNative
    member __.unskipHeader(): unit = jsNative
    member __.skipMatchingFields(): unit = jsNative
    member __.skipVarintField(): unit = jsNative
    member __.skipDelimitedField(): unit = jsNative
    member __.skipFixed32Field(): unit = jsNative
    member __.skipFixed64Field(): unit = jsNative
    member __.skipGroup(): unit = jsNative
    member __.skipField(): unit = jsNative
    member __.registerReadCallback(callbackName: string, callback: Func<BinaryReader, obj>): unit = jsNative
    member __.runReadCallback(callbackName: string): obj = jsNative
    member __.readAny(fieldType: BinaryConstants.FieldType): AnyFieldType = jsNative
    member __.readGroup(field: float, message: Message, reader: BinaryReadReader): unit = jsNative
    member __.getFieldDecoder(): BinaryDecoder = jsNative
    member __.readInt32(): float = jsNative
    member __.readInt32String(): string = jsNative
    member __.readInt64(): float = jsNative
    member __.readInt64String(): string = jsNative
    member __.readUint32(): float = jsNative
    member __.readUint32String(): string = jsNative
    member __.readUint64(): float = jsNative
    member __.readUint64String(): string = jsNative
    member __.readSint32(): float = jsNative
    member __.readSint64(): float = jsNative
    member __.readSint64String(): string = jsNative
    member __.readFixed32(): float = jsNative
    member __.readFixed64(): float = jsNative
    member __.readFixed64String(): string = jsNative
    member __.readSfixed32(): float = jsNative
    member __.readSfixed32String(): string = jsNative
    member __.readSfixed64(): float = jsNative
    member __.readSfixed64String(): string = jsNative
    member __.readFloat(): float = jsNative
    member __.readDouble(): float = jsNative
    member __.readBool(): bool = jsNative
    member __.readEnum(): float = jsNative
    member __.readString(): string = jsNative
    member __.readBytes(): Uint8Array = jsNative
    member __.readVarintHash64(): string = jsNative
    member __.readFixedHash64(): string = jsNative
    member __.readPackedInt32(): ResizeArray<float> = jsNative
    member __.readPackedInt32String(): ResizeArray<string> = jsNative
    member __.readPackedInt64(): ResizeArray<float> = jsNative
    member __.readPackedInt64String(): ResizeArray<string> = jsNative
    member __.readPackedUint32(): ResizeArray<float> = jsNative
    member __.readPackedUint32String(): ResizeArray<string> = jsNative
    member __.readPackedUint64(): ResizeArray<float> = jsNative
    member __.readPackedUint64String(): ResizeArray<string> = jsNative
    member __.readPackedSint32(): ResizeArray<float> = jsNative
    member __.readPackedSint64(): ResizeArray<float> = jsNative
    member __.readPackedSint64String(): ResizeArray<string> = jsNative
    member __.readPackedFixed32(): ResizeArray<float> = jsNative
    member __.readPackedFixed64(): ResizeArray<float> = jsNative
    member __.readPackedFixed64String(): ResizeArray<string> = jsNative
    member __.readPackedSfixed32(): ResizeArray<float> = jsNative
    member __.readPackedSfixed64(): ResizeArray<float> = jsNative
    member __.readPackedSfixed64String(): ResizeArray<string> = jsNative
    member __.readPackedFloat(): ResizeArray<float> = jsNative
    member __.readPackedDouble(): ResizeArray<float> = jsNative
    member __.readPackedBool(): ResizeArray<bool> = jsNative
    member __.readPackedEnum(): ResizeArray<float> = jsNative
    member __.readPackedVarintHash64(): ResizeArray<string> = jsNative
    member __.readPackedFixedHash64(): ResizeArray<string> = jsNative

and [<AllowNullLiteral>] [<Import("*","BinaryWriter")>] BinaryWriter() =
    member __.writeMessage with get(): BinaryWrite = jsNative and set(v: BinaryWrite): unit = jsNative
    member __.writeSerializedMessage(bytes: Uint8Array, start: float, ``end``: float): unit = jsNative
    member __.maybeWriteSerializedMessage(?bytes: Uint8Array, ?start: float, ?``end``: float): unit = jsNative
    member __.reset(): unit = jsNative
    member __.getResultBuffer(): Uint8Array = jsNative
    member __.getResultBase64String(): string = jsNative
    member __.beginSubMessage(field: float): unit = jsNative
    member __.endSubMessage(field: float): unit = jsNative
    member __.writeAny(fieldType: BinaryConstants.FieldType, field: float, value: AnyFieldType): unit = jsNative
    member __.writeInt32(field: float, ?value: float): unit = jsNative
    member __.writeInt32String(field: float, ?value: string): unit = jsNative
    member __.writeInt64(field: float, ?value: float): unit = jsNative
    member __.writeInt64String(field: float, ?value: string): unit = jsNative
    member __.writeUint32(field: float, ?value: float): unit = jsNative
    member __.writeUint32String(field: float, ?value: string): unit = jsNative
    member __.writeUint64(field: float, ?value: float): unit = jsNative
    member __.writeUint64String(field: float, ?value: string): unit = jsNative
    member __.writeSint32(field: float, ?value: float): unit = jsNative
    member __.writeSint64(field: float, ?value: float): unit = jsNative
    member __.writeSint64String(field: float, ?value: string): unit = jsNative
    member __.writeFixed32(field: float, ?value: float): unit = jsNative
    member __.writeFixed64(field: float, ?value: float): unit = jsNative
    member __.writeFixed64String(field: float, ?value: string): unit = jsNative
    member __.writeSfixed32(field: float, ?value: float): unit = jsNative
    member __.writeSfixed64(field: float, ?value: float): unit = jsNative
    member __.writeSfixed64String(field: float, ?value: string): unit = jsNative
    member __.writeFloat(field: float, ?value: float): unit = jsNative
    member __.writeDouble(field: float, ?value: float): unit = jsNative
    member __.writeBool(field: float, ?value: bool): unit = jsNative
    member __.writeEnum(field: float, ?value: float): unit = jsNative
    member __.writeString(field: float, ?value: string): unit = jsNative
    member __.writeBytes(field: float, ?value: ByteSource): unit = jsNative
    member __.writeGroup(field: float, value: obj, writeCallback: BinaryWriteCallback): unit = jsNative
    member __.writeFixedHash64(field: float, ?value: string): unit = jsNative
    member __.writeVarintHash64(field: float, ?value: string): unit = jsNative
    member __.writeRepeatedInt32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedInt32String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedInt64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedInt64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedUint32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedUint32String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedUint64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedUint64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedSint32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedSint64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedSint64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedFixed32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedFixed64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedFixed64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedSfixed32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedSfixed64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedSfixed64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedFloat(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedDouble(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedBool(field: float, ?value: ResizeArray<bool>): unit = jsNative
    member __.writeRepeatedEnum(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writeRepeatedString(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedBytes(field: float, ?value: ResizeArray<ByteSource>): unit = jsNative
    member __.writeRepeatedMessage(field: float, value: ResizeArray<Message>, writerCallback: BinaryWriteCallback): unit = jsNative
    member __.writeRepeatedGroup(field: float, value: ResizeArray<Message>, writerCallback: BinaryWriteCallback): unit = jsNative
    member __.writeRepeatedFixedHash64(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writeRepeatedVarintHash64(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedInt32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedInt32String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedInt64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedInt64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedUint32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedUint32String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedUint64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedUint64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedSint32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedSint64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedSint64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedFixed32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedFixed64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedFixed64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedSfixed32(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedSfixed64(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedSfixed64String(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedFloat(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedDouble(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedBool(field: float, ?value: ResizeArray<bool>): unit = jsNative
    member __.writePackedEnum(field: float, ?value: ResizeArray<float>): unit = jsNative
    member __.writePackedFixedHash64(field: float, ?value: ResizeArray<string>): unit = jsNative
    member __.writePackedVarintHash64(field: float, ?value: ResizeArray<string>): unit = jsNative

and [<AllowNullLiteral>] [<Import("*","BinaryEncoder")>] BinaryEncoder() =
    member __.length(): float = jsNative
    member __.``end``(): ResizeArray<float> = jsNative
    member __.writeSplitVarint64(lowBits: float, highBits: float): unit = jsNative
    member __.writeSplitFixed64(lowBits: float, highBits: float): unit = jsNative
    member __.writeUnsignedVarint32(value: float): unit = jsNative
    member __.writeSignedVarint32(value: float): unit = jsNative
    member __.writeUnsignedVarint64(value: float): unit = jsNative
    member __.writeSignedVarint64(value: float): unit = jsNative
    member __.writeZigzagVarint32(value: float): unit = jsNative
    member __.writeZigzagVarint64(value: float): unit = jsNative
    member __.writeZigzagVarint64String(value: string): unit = jsNative
    member __.writeUint8(value: float): unit = jsNative
    member __.writeUint16(value: float): unit = jsNative
    member __.writeUint32(value: float): unit = jsNative
    member __.writeUint64(value: float): unit = jsNative
    member __.writeInt8(value: float): unit = jsNative
    member __.writeInt16(value: float): unit = jsNative
    member __.writeInt32(value: float): unit = jsNative
    member __.writeInt64(value: float): unit = jsNative
    member __.writeInt64String(value: string): unit = jsNative
    member __.writeFloat(value: float): unit = jsNative
    member __.writeDouble(value: float): unit = jsNative
    member __.writeBool(value: bool): unit = jsNative
    member __.writeEnum(value: float): unit = jsNative
    member __.writeBytes(bytes: Uint8Array): unit = jsNative
    member __.writeVarintHash64(hash: string): unit = jsNative
    member __.writeFixedHash64(hash: string): unit = jsNative
    member __.writeString(value: string): float = jsNative

and [<AllowNullLiteral>] [<Import("*","BinaryDecoder")>] BinaryDecoder(?bytes: ByteSource, ?start: float, ?length: float) =
    static member alloc(?bytes: ByteSource, ?start: float, ?length: float): BinaryDecoder = jsNative
    member __.free(): unit = jsNative
    member __.clone(): BinaryDecoder = jsNative
    member __.clear(): unit = jsNative
    member __.getBuffer(): Uint8Array = jsNative
    member __.setBlock(data: ByteSource, ?start: float, ?length: float): unit = jsNative
    member __.getEnd(): float = jsNative
    member __.setEnd(``end``: float): unit = jsNative
    member __.reset(): unit = jsNative
    member __.getCursor(): float = jsNative
    member __.setCursor(cursor: float): unit = jsNative
    member __.advance(count: float): unit = jsNative
    member __.atEnd(): bool = jsNative
    member __.pastEnd(): bool = jsNative
    member __.getError(): bool = jsNative
    member __.skipVarint(): unit = jsNative
    member __.unskipVarint(value: float): unit = jsNative
    member __.readUnsignedVarint32(): float = jsNative
    member __.readSignedVarint32(): float = jsNative
    member __.readUnsignedVarint32String(): float = jsNative
    member __.readSignedVarint32String(): float = jsNative
    member __.readZigzagVarint32(): float = jsNative
    member __.readUnsignedVarint64(): float = jsNative
    member __.readUnsignedVarint64String(): float = jsNative
    member __.readSignedVarint64(): float = jsNative
    member __.readSignedVarint64String(): float = jsNative
    member __.readZigzagVarint64(): float = jsNative
    member __.readZigzagVarint64String(): float = jsNative
    member __.readUint8(): float = jsNative
    member __.readUint16(): float = jsNative
    member __.readUint32(): float = jsNative
    member __.readUint64(): float = jsNative
    member __.readUint64String(): string = jsNative
    member __.readInt8(): float = jsNative
    member __.readInt16(): float = jsNative
    member __.readInt32(): float = jsNative
    member __.readInt64(): float = jsNative
    member __.readInt64String(): string = jsNative
    member __.readFloat(): float = jsNative
    member __.readDouble(): float = jsNative
    member __.readBool(): bool = jsNative
    member __.readEnum(): float = jsNative
    member __.readString(length: float): string = jsNative
    member __.readStringWithLength(): string = jsNative
    member __.readBytes(length: float): Uint8Array = jsNative
    member __.readVarintHash64(): string = jsNative
    member __.readFixedHash64(): string = jsNative

and [<AllowNullLiteral>] [<Import("*","BinaryIterator")>] BinaryIterator(?decoder: BinaryDecoder, ?next: Func<unit, U4<float, bool, string, obj>>, ?elements: ResizeArray<U3<float, bool, string>>) =
    member __.``null`` with get(): obj = jsNative and set(v: obj): unit = jsNative
    member __.``null`` with get(): obj = jsNative and set(v: obj): unit = jsNative
    static member alloc(?decoder: BinaryDecoder, ?next: Func<unit, U4<float, bool, string, obj>>, ?elements: ResizeArray<U3<float, bool, string>>): BinaryIterator = jsNative
    member __.free(): unit = jsNative
    member __.clear(): unit = jsNative
    member __.get(): U2<ScalarFieldType, obj> = jsNative
    member __.atEnd(): bool = jsNative
    member __.next(): U2<ScalarFieldType, obj> = jsNative

module Message =
    type [<AllowNullLiteral>] MessageArray =
        ResizeArray<obj>

    and [<AllowNullLiteral>] StaticToObject =
        Func<bool, Message, obj>



module Map =
    type [<AllowNullLiteral>] Iterator<'T> =
        abstract next: unit -> IteratorResult<'T>

    and [<AllowNullLiteral>] IteratorResult<'T> =
        abstract ``done``: bool with get, set
        abstract value: 'T with get, set



module BinaryConstants =
    type [<AllowNullLiteral>] FieldType =
        | INVALID = undefined
        | DOUBLE = 1
        | FLOAT = 2
        | INT64 = 3
        | UINT64 = 4
        | INT32 = 5
        | FIXED64 = 6
        | FIXED32 = 7
        | BOOL = 8
        | STRING = 9
        | GROUP = 10
        | MESSAGE = 11
        | BYTES = 12
        | UINT32 = 13
        | ENUM = 14
        | SFIXED32 = 15
        | SFIXED64 = 16
        | SINT32 = 17
        | SINT64 = 18
        | FHASH64 = 30
        | VHASH64 = 31

    and [<AllowNullLiteral>] WireType =
        | INVALID = undefined
        | VARINT = 0
        | FIXED64 = 1
        | DELIMITED = 2
        | START_GROUP = 3
        | END_GROUP = 4
        | FIXED32 = 5

    type [<Import("*","BinaryConstants")>] Globals =
        static member FieldTypeToWireType with get(): Func<FieldType, WireType> = jsNative and set(v: Func<FieldType, WireType>): unit = jsNative
        static member INVALID_FIELD_NUMBER with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT32_EPS with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT32_MIN with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT32_MAX with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT64_EPS with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT64_MIN with get(): float = jsNative and set(v: float): unit = jsNative
        static member FLOAT64_MAX with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_20 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_23 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_31 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_32 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_52 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_63 with get(): float = jsNative and set(v: float): unit = jsNative
        static member TWO_TO_64 with get(): float = jsNative and set(v: float): unit = jsNative
        static member ZERO_HASH with get(): string = jsNative and set(v: string): unit = jsNative



module arith =
    type [<AllowNullLiteral>] [<Import("UInt64","arith")>] UInt64(lo: float, hi: float) =
        member __.lo with get(): float = jsNative and set(v: float): unit = jsNative
        member __.hi with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cmp(other: UInt64): float = jsNative
        member __.rightShift(): UInt64 = jsNative
        member __.leftShift(): UInt64 = jsNative
        member __.msb(): bool = jsNative
        member __.lsb(): bool = jsNative
        member __.zero(): bool = jsNative
        member __.add(other: UInt64): UInt64 = jsNative
        member __.sub(other: UInt64): UInt64 = jsNative
        static member mul32x32(a: float, b: float): UInt64 = jsNative
        member __.mul(a: float): UInt64 = jsNative
        member __.div(divisor: float): UInt64 * UInt64 = jsNative
        member __.toString(): string = jsNative
        static member fromString(str: string): UInt64 = jsNative
        member __.clone(): UInt64 = jsNative

    and [<AllowNullLiteral>] [<Import("Int64","arith")>] Int64(lo: float, hi: float) =
        member __.lo with get(): float = jsNative and set(v: float): unit = jsNative
        member __.hi with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(other: Int64): Int64 = jsNative
        member __.sub(other: Int64): Int64 = jsNative
        member __.clone(): Int64 = jsNative
        member __.toString(): string = jsNative
        static member fromString(str: string): Int64 = jsNative


