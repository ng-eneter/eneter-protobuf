..\proto\ProtoGen\protogen.exe -i:EneterProtoBufDeclarations.proto -o:EneterProtoBufDeclarations.cs -p:detectMissing -p:lightFramework -ns:Eneter.ProtoBuf

..\proto\protoc\protoc.exe -I=./ --java_out=./ ./EneterProtoBufDeclarations.proto
..\proto\protoc\protoc.exe -I=./ --java_out=./ ./EneterProtoBufPrimitivesDeclarations.proto