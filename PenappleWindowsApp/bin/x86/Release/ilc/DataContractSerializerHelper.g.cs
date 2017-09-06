using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 245
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                798, // index: 798, string: "Authority"
                808, // index: 808, string: "AuthorizeEndpoint"
                826, // index: 826, string: "DeviceCodeEndpoint"
                845, // index: 845, string: "Host"
                850, // index: 850, string: "InstanceDiscoveryEndpoint"
                876, // index: 876, string: "Issuer"
                883, // index: 883, string: "TokenEndpoint"
                897, // index: 897, string: "UserRealmEndpoint"
                8, // array length: 8
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                915, // index: 915, string: "home_oid"
                924, // index: 924, string: "iss"
                928, // index: 928, string: "name"
                933, // index: 933, string: "oid"
                937, // index: 937, string: "preferred_username"
                956, // index: 956, string: "sub"
                960, // index: 960, string: "tid"
                964, // index: 964, string: "ver"
                8, // array length: 8
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                3, // array length: 3
                -1, // string: null
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                3, // array length: 3
                968, // index: 968, string: "RefreshToken"
                981, // index: 981, string: "Result"
                988, // index: 988, string: "UserAssertionHash"
                3, // array length: 3
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                485, // index: 485, string: "http://schemas.datacontract.org/2004/07/System"
                -1, // string: null
                -1, // string: null
                546, // index: 546, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                8, // array length: 8
                1006, // index: 1006, string: "ExpiresOn"
                1016, // index: 1016, string: "FamilyId"
                352, // index: 352, string: "IdToken"
                1025, // index: 1025, string: "ScopeSet"
                1034, // index: 1034, string: "TenantId"
                1043, // index: 1043, string: "Token"
                1049, // index: 1049, string: "TokenType"
                604, // index: 604, string: "User"
                8, // array length: 8
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                485, // index: 485, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                1059, // index: 1059, string: "DateTime"
                1068, // index: 1068, string: "OffsetMinutes"
                2, // array length: 2
                485, // index: 485, string: "http://schemas.datacontract.org/2004/07/System"
                485, // index: 485, string: "http://schemas.datacontract.org/2004/07/System"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                5, // array length: 5
                1082, // index: 1082, string: "DisplayableId"
                1096, // index: 1096, string: "HomeObjectId"
                1109, // index: 1109, string: "IdentityProvider"
                1126, // index: 1126, string: "Name"
                1131, // index: 1131, string: "UniqueId"
                5, // array length: 5
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                404, // index: 404, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                12, // array length: 12
                -1, // string: null
                -1, // string: null
                -1, // string: null
                546, // index: 546, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                12, // array length: 12
                1140, // index: 1140, string: "access_token"
                1153, // index: 1153, string: "correlation_id"
                1168, // index: 1168, string: "error"
                1174, // index: 1174, string: "error_codes"
                1186, // index: 1186, string: "error_description"
                1204, // index: 1204, string: "expires_in"
                1215, // index: 1215, string: "foci"
                1220, // index: 1220, string: "id_token"
                1229, // index: 1229, string: "id_token_expires_in"
                1249, // index: 1249, string: "refresh_token"
                1263, // index: 1263, string: "scope"
                1269, // index: 1269, string: "token_type"
                12, // array length: 12
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                6, // array length: 6
                1280, // index: 1280, string: "aud"
                1284, // index: 1284, string: "exp"
                924, // index: 924, string: "iss"
                1288, // index: 1288, string: "jti"
                1292, // index: 1292, string: "nbf"
                956, // index: 956, string: "sub"
                6, // array length: 6
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                1296, // index: 1296, string: "alg"
                1300, // index: 1300, string: "kid"
                2, // array length: 2
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                1296, // index: 1296, string: "alg"
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                1304, // index: 1304, string: "tenant_discovery_endpoint"
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                5, // array length: 5
                1330, // index: 1330, string: "account_type"
                1343, // index: 1343, string: "federation_active_auth_url"
                1370, // index: 1370, string: "federation_metadata_url"
                1394, // index: 1394, string: "federation_protocol"
                964, // index: 964, string: "ver"
                5, // array length: 5
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277, // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                277  // index: 277, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=53
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                "eyToken=31bf3856ad364e35")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                "eutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                "3856ad364e35")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                "neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                "eutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=12
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // AuthenticatorTemplate
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 255, // AuthenticatorTemplate
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 255, // AuthenticatorTemplate
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 10,
                    MemberNamesListIndex = 12,
                    MemberNamespacesListIndex = 21,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 352, // IdToken
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 352, // IdToken
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 352, // IdToken
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 30,
                    ContractNamespacesListIndex = 39,
                    MemberNamesListIndex = 41,
                    MemberNamespacesListIndex = 50,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 360, // AuthenticationResultEx
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 360, // AuthenticationResultEx
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 360, // AuthenticationResultEx
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 59,
                    ContractNamespacesListIndex = 63,
                    MemberNamesListIndex = 65,
                    MemberNamespacesListIndex = 69,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 383, // AuthenticationResult
                        NamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        StableNameIndex = 383, // AuthenticationResult
                        StableNameNamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        TopLevelElementNameIndex = 383, // AuthenticationResult
                        TopLevelElementNamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 73,
                    ContractNamespacesListIndex = 82,
                    MemberNamesListIndex = 84,
                    MemberNamespacesListIndex = 93,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 470, // DateTimeOffset
                        NamespaceIndex = 485, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 470, // DateTimeOffset
                        StableNameNamespaceIndex = 485, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 470, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 485, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 102,
                    ContractNamespacesListIndex = 105,
                    MemberNamesListIndex = 107,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 604, // User
                        NamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        StableNameIndex = 604, // User
                        StableNameNamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        TopLevelElementNameIndex = 604, // User
                        TopLevelElementNamespaceIndex = 404, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                    "3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                    "3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 119,
                    MemberNamesListIndex = 121,
                    MemberNamespacesListIndex = 127,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 609, // TokenResponse
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 609, // TokenResponse
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 609, // TokenResponse
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 133,
                    ContractNamespacesListIndex = 146,
                    MemberNamesListIndex = 148,
                    MemberNamespacesListIndex = 161,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 623, // JsonWebToken.JWTPayload
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 623, // JsonWebToken.JWTPayload
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 623, // JsonWebToken.JWTPayload
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                    "neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                    "neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 174,
                    ContractNamespacesListIndex = 181,
                    MemberNamesListIndex = 183,
                    MemberNamespacesListIndex = 190,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 647, // JsonWebToken.JWTHeaderWithCertificate
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 647, // JsonWebToken.JWTHeaderWithCertificate
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 647, // JsonWebToken.JWTHeaderWithCertificate
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                    ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                    ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 197,
                    ContractNamespacesListIndex = 200,
                    MemberNamesListIndex = 203,
                    MemberNamespacesListIndex = 206,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 685, // JsonWebToken.JWTHeader
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 685, // JsonWebToken.JWTHeader
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 685, // JsonWebToken.JWTHeader
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 209,
                    ContractNamespacesListIndex = 211,
                    MemberNamesListIndex = 213,
                    MemberNamespacesListIndex = 215,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 708, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 708, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 708, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                    "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                    "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 217,
                    ContractNamespacesListIndex = 219,
                    MemberNamesListIndex = 221,
                    MemberNamespacesListIndex = 223,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 756, // UserRealmDiscoveryResponse
                        NamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 756, // UserRealmDiscoveryResponse
                        StableNameNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 756, // UserRealmDiscoveryResponse
                        TopLevelElementNamespaceIndex = 277, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 225,
                    ContractNamespacesListIndex = 231,
                    MemberNamesListIndex = 233,
                    MemberNamespacesListIndex = 239,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=3
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 532, // ArrayOfstring
                        NamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 532, // ArrayOfstring
                        StableNameNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 532, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 532, // ArrayOfstring
                        NamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 532, // ArrayOfstring
                        StableNameNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 532, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 783, // ArrayOfanyType
                        NamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 783, // ArrayOfanyType
                        StableNameNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 783, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 546, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=15
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteAuthenticatorTemplateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadAuthenticatorTemplateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteIdTokenToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadIdTokenFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type11.WriteAuthenticationResultExToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type10.ReadAuthenticationResultExFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type15.WriteAuthenticationResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type14.ReadAuthenticationResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type19.WriteDateTimeOffsetToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type18.ReadDateTimeOffsetFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type24.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type23.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type25.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type29.WriteUserToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type28.ReadUserFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type33.WriteTokenResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type32.ReadTokenResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type38.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type37.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type39.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type43.WriteJsonWebToken_JWTPayloadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type42.ReadJsonWebToken_JWTPayloadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type47.WriteJsonWebToken_JWTHeaderWithCertificateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type46.ReadJsonWebToken_JWTHeaderWithCertificateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type51.WriteJsonWebToken_JWTHeaderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type50.ReadJsonWebToken_JWTHeaderFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type55.WriteAuthenticatorTemplate_InstanceDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type54.ReadAuthenticatorTemplate_InstanceDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteUserRealmDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadUserRealmDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type64.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type63.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type65.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','u','t','h','e','n','t','i','c','a','t','o','r','T','e',
            'm','p','l','a','t','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t',
            'r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d','e',
            'n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','\0','I','d','T','o','k','e','n','\0',
            'A','u','t','h','e','n','t','i','c','a','t','i','o','n','R','e','s','u','l','t','E','x','\0','A','u','t','h','e','n','t',
            'i','c','a','t','i','o','n','R','e','s','u','l','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d',
            'a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s',
            'o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','\0','D','a','t','e','T','i','m','e','O','f',
            'f','s','e','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a',
            'c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','\0','A','r','r','a','y','O','f','s',
            't','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t',
            '.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r',
            'a','y','s','\0','U','s','e','r','\0','T','o','k','e','n','R','e','s','p','o','n','s','e','\0','J','s','o','n','W','e','b',
            'T','o','k','e','n','.','J','W','T','P','a','y','l','o','a','d','\0','J','s','o','n','W','e','b','T','o','k','e','n','.',
            'J','W','T','H','e','a','d','e','r','W','i','t','h','C','e','r','t','i','f','i','c','a','t','e','\0','J','s','o','n','W',
            'e','b','T','o','k','e','n','.','J','W','T','H','e','a','d','e','r','\0','A','u','t','h','e','n','t','i','c','a','t','o',
            'r','T','e','m','p','l','a','t','e','.','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','R','e','s',
            'p','o','n','s','e','\0','U','s','e','r','R','e','a','l','m','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n',
            's','e','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','A','u','t','h','o','r','i','t','y','\0','A','u',
            't','h','o','r','i','z','e','E','n','d','p','o','i','n','t','\0','D','e','v','i','c','e','C','o','d','e','E','n','d','p',
            'o','i','n','t','\0','H','o','s','t','\0','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','E','n','d',
            'p','o','i','n','t','\0','I','s','s','u','e','r','\0','T','o','k','e','n','E','n','d','p','o','i','n','t','\0','U','s','e',
            'r','R','e','a','l','m','E','n','d','p','o','i','n','t','\0','h','o','m','e','_','o','i','d','\0','i','s','s','\0','n','a',
            'm','e','\0','o','i','d','\0','p','r','e','f','e','r','r','e','d','_','u','s','e','r','n','a','m','e','\0','s','u','b','\0',
            't','i','d','\0','v','e','r','\0','R','e','f','r','e','s','h','T','o','k','e','n','\0','R','e','s','u','l','t','\0','U','s',
            'e','r','A','s','s','e','r','t','i','o','n','H','a','s','h','\0','E','x','p','i','r','e','s','O','n','\0','F','a','m','i',
            'l','y','I','d','\0','S','c','o','p','e','S','e','t','\0','T','e','n','a','n','t','I','d','\0','T','o','k','e','n','\0','T',
            'o','k','e','n','T','y','p','e','\0','D','a','t','e','T','i','m','e','\0','O','f','f','s','e','t','M','i','n','u','t','e',
            's','\0','D','i','s','p','l','a','y','a','b','l','e','I','d','\0','H','o','m','e','O','b','j','e','c','t','I','d','\0','I',
            'd','e','n','t','i','t','y','P','r','o','v','i','d','e','r','\0','N','a','m','e','\0','U','n','i','q','u','e','I','d','\0',
            'a','c','c','e','s','s','_','t','o','k','e','n','\0','c','o','r','r','e','l','a','t','i','o','n','_','i','d','\0','e','r',
            'r','o','r','\0','e','r','r','o','r','_','c','o','d','e','s','\0','e','r','r','o','r','_','d','e','s','c','r','i','p','t',
            'i','o','n','\0','e','x','p','i','r','e','s','_','i','n','\0','f','o','c','i','\0','i','d','_','t','o','k','e','n','\0','i',
            'd','_','t','o','k','e','n','_','e','x','p','i','r','e','s','_','i','n','\0','r','e','f','r','e','s','h','_','t','o','k',
            'e','n','\0','s','c','o','p','e','\0','t','o','k','e','n','_','t','y','p','e','\0','a','u','d','\0','e','x','p','\0','j','t',
            'i','\0','n','b','f','\0','a','l','g','\0','k','i','d','\0','t','e','n','a','n','t','_','d','i','s','c','o','v','e','r','y',
            '_','e','n','d','p','o','i','n','t','\0','a','c','c','o','u','n','t','_','t','y','p','e','\0','f','e','d','e','r','a','t',
            'i','o','n','_','a','c','t','i','v','e','_','a','u','t','h','_','u','r','l','\0','f','e','d','e','r','a','t','i','o','n',
            '_','m','e','t','a','d','a','t','a','_','u','r','l','\0','f','e','d','e','r','a','t','i','o','n','_','p','r','o','t','o',
            'c','o','l','\0'};
    }
}
