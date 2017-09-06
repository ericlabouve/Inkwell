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
              -1,   60,   62,   -1,   56,   57,   60,   -1, }
        ;
        // Count = 554
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                5, // array length: 5
                2195, // index: 2195, string: "HelpLink"
                2204, // index: 2204, string: "InnerException"
                2219, // index: 2219, string: "Message"
                2227, // index: 2227, string: "StackTrace"
                2238, // index: 2238, string: "Type"
                5, // array length: 5
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                4, // array length: 4
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                2243, // index: 2243, string: "Properties"
                2254, // index: 2254, string: "Attachments"
                2266, // index: 2266, string: "Messages"
                802, // index: 802, string: "TestCase"
                4, // array length: 4
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                2243, // index: 2243, string: "Properties"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2275, // index: 2275, string: "key"
                2279, // index: 2279, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                6, // array length: 6
                2285, // index: 2285, string: "Attributes"
                2296, // index: 2296, string: "Category"
                2305, // index: 2305, string: "Description"
                2317, // index: 2317, string: "Id"
                2320, // index: 2320, string: "Label"
                2326, // index: 2326, string: "ValueType"
                6, // array length: 6
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                653, // index: 653, string: "None"
                658, // index: 658, string: "Hidden"
                665, // index: 665, string: "Immutable"
                675, // index: 675, string: "Trait"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                3, // array length: 3
                2254, // index: 2254, string: "Attachments"
                2336, // index: 2336, string: "DisplayName"
                2348, // index: 2348, string: "Uri"
                3, // array length: 3
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                2305, // index: 2305, string: "Description"
                2348, // index: 2348, string: "Uri"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                2296, // index: 2296, string: "Category"
                2352, // index: 2352, string: "Text"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                2243, // index: 2243, string: "Properties"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2275, // index: 2275, string: "key"
                2279, // index: 2279, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                5, // array length: 5
                653, // index: 653, string: "None"
                956, // index: 956, string: "Passed"
                963, // index: 963, string: "Failed"
                970, // index: 970, string: "Skipped"
                978, // index: 978, string: "NotFound"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                2357, // index: 2357, string: "DateTime"
                2366, // index: 2366, string: "OffsetMinutes"
                2, // array length: 2
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                2380, // index: 2380, string: "ExecutedTests"
                2394, // index: 2394, string: "Stats"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2275, // index: 2275, string: "key"
                2279, // index: 2279, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                2219, // index: 2219, string: "Message"
                2400, // index: 2400, string: "MessageLevel"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                1424, // index: 1424, string: "Informational"
                1438, // index: 1438, string: "Warning"
                1446, // index: 1446, string: "Error"
                3, // array length: 3
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                3, // array length: 3
                2413, // index: 2413, string: "Data"
                2195, // index: 2195, string: "HelpLink"
                2418, // index: 2418, string: "Source"
                3, // array length: 3
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                2425, // index: 2425, string: "Contract"
                2434, // index: 2434, string: "InitParams"
                2445, // index: 2445, string: "TestRunParams"
                3, // array length: 3
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                6, // array length: 6
                1638, // index: 1638, string: "CancelTestRun"
                1652, // index: 1652, string: "InitializeConnection"
                653, // index: 653, string: "None"
                1673, // index: 1673, string: "Shutdown"
                1682, // index: 1682, string: "StartTestRun"
                1695, // index: 1695, string: "StartTestRunWithSources"
                2, // array length: 2
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                2459, // index: 2459, string: "LoadOnlyWellKnownExtensions"
                2487, // index: 2487, string: "PathToAdditionalExtensions"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                2514, // index: 2514, string: "DataCollectorServiceUri"
                2538, // index: 2538, string: "ExecutionContext"
                2555, // index: 2555, string: "Sources"
                2563, // index: 2563, string: "TestRunSettings"
                2579, // index: 2579, string: "Tests"
                5, // array length: 5
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                2585, // index: 2585, string: "AreTestCaseLevelEventsRequired"
                2616, // index: 2616, string: "FrequencyOfRunStatsChangeEvent"
                2647, // index: 2647, string: "InIsolation"
                2659, // index: 2659, string: "IsDebug"
                2667, // index: 2667, string: "KeepAlive"
                2677, // index: 2677, string: "RunStatsChangeEventTimeout"
                2704, // index: 2704, string: "TestCaseFilter"
                7, // array length: 7
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
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
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                2719, // index: 2719, string: "Authority"
                2729, // index: 2729, string: "AuthorizeEndpoint"
                2747, // index: 2747, string: "DeviceCodeEndpoint"
                2766, // index: 2766, string: "Host"
                2771, // index: 2771, string: "InstanceDiscoveryEndpoint"
                2797, // index: 2797, string: "Issuer"
                2804, // index: 2804, string: "TokenEndpoint"
                2818, // index: 2818, string: "UserRealmEndpoint"
                8, // array length: 8
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
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
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                2836, // index: 2836, string: "home_oid"
                2845, // index: 2845, string: "iss"
                2849, // index: 2849, string: "name"
                2854, // index: 2854, string: "oid"
                2858, // index: 2858, string: "preferred_username"
                2877, // index: 2877, string: "sub"
                2881, // index: 2881, string: "tid"
                2885, // index: 2885, string: "ver"
                8, // array length: 8
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                3, // array length: 3
                -1, // string: null
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                3, // array length: 3
                2889, // index: 2889, string: "RefreshToken"
                2902, // index: 2902, string: "Result"
                2909, // index: 2909, string: "UserAssertionHash"
                3, // array length: 3
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                8, // array length: 8
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                -1, // string: null
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                8, // array length: 8
                2927, // index: 2927, string: "ExpiresOn"
                2937, // index: 2937, string: "FamilyId"
                1883, // index: 1883, string: "IdToken"
                2946, // index: 2946, string: "ScopeSet"
                2955, // index: 2955, string: "TenantId"
                2964, // index: 2964, string: "Token"
                2970, // index: 2970, string: "TokenType"
                2001, // index: 2001, string: "User"
                8, // array length: 8
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                5, // array length: 5
                2980, // index: 2980, string: "DisplayableId"
                2994, // index: 2994, string: "HomeObjectId"
                3007, // index: 3007, string: "IdentityProvider"
                3024, // index: 3024, string: "Name"
                3029, // index: 3029, string: "UniqueId"
                5, // array length: 5
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                1935, // index: 1935, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client"
                12, // array length: 12
                -1, // string: null
                -1, // string: null
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                12, // array length: 12
                3038, // index: 3038, string: "access_token"
                3051, // index: 3051, string: "correlation_id"
                3066, // index: 3066, string: "error"
                3072, // index: 3072, string: "error_codes"
                3084, // index: 3084, string: "error_description"
                3102, // index: 3102, string: "expires_in"
                3113, // index: 3113, string: "foci"
                3118, // index: 3118, string: "id_token"
                3127, // index: 3127, string: "id_token_expires_in"
                3147, // index: 3147, string: "refresh_token"
                3161, // index: 3161, string: "scope"
                3167, // index: 3167, string: "token_type"
                12, // array length: 12
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                6, // array length: 6
                3178, // index: 3178, string: "aud"
                3182, // index: 3182, string: "exp"
                2845, // index: 2845, string: "iss"
                3186, // index: 3186, string: "jti"
                3190, // index: 3190, string: "nbf"
                2877, // index: 2877, string: "sub"
                6, // array length: 6
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                2, // array length: 2
                3194, // index: 3194, string: "alg"
                3198, // index: 3198, string: "kid"
                2, // array length: 2
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                3194, // index: 3194, string: "alg"
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1, // array length: 1
                3202, // index: 3202, string: "tenant_discovery_endpoint"
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                5, // array length: 5
                3228, // index: 3228, string: "account_type"
                3241, // index: 3241, string: "federation_active_auth_url"
                3268, // index: 3268, string: "federation_metadata_url"
                3292, // index: 3292, string: "federation_protocol"
                2885, // index: 2885, string: "ver"
                5, // array length: 5
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808, // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
                1808  // index: 1808, string: "http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal"
        };
        // Count = 18
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 658, // Hidden
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 665, // Immutable
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 675, // Trait
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 956, // Passed
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 963, // Failed
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 970, // Skipped
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 978, // NotFound
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1424, // Informational
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1438, // Warning
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1446, // Error
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1638, // CancelTestRun
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1652, // InitializeConnection
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1673, // Shutdown
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1682, // StartTestRun
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1695, // StartTestRunWithSources
                    Value = 5,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=109
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
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 258, // 0x102
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 274, // 0x112
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 290, // 0x122
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 306, // 0x132
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 322, // 0x142
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 338, // 0x152
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                "eyToken=31bf3856ad364e35")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                "eutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 354, // 0x162
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                "3856ad364e35")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                "neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 449, // 0x1c1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 465, // 0x1d1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                "eutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 481, // 0x1e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 497, // 0x1f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 513, // 0x201
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 370, // 0x172
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
        // Count=33
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ExceptionDetail
                        NamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        StableNameIndex = 255, // ExceptionDetail
                        StableNameNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        TopLevelElementNameIndex = 255, // ExceptionDetail
                        TopLevelElementNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadExceptionDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteExceptionDetailToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 437, // TestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 437, // TestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 437, // TestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type5.ReadTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type6.WriteTestResultToXml),
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 26,
                    MemberNamesListIndex = 29,
                    MemberNamespacesListIndex = 34,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 448, // TestObject
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 448, // TestObject
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 448, // TestObject
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadTestObjectFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteTestObjectToXml),
                    ChildElementNamespacesListIndex = 39,
                    ContractNamespacesListIndex = 41,
                    MemberNamesListIndex = 43,
                    MemberNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WriteKeyValuePairOfTestPropertyanyTypeGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 50,
                    MemberNamesListIndex = 52,
                    MemberNamespacesListIndex = 55,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 617, // TestProperty
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 617, // TestProperty
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 617, // TestProperty
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type14.ReadTestPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type15.WriteTestPropertyToXml),
                    ChildElementNamespacesListIndex = 58,
                    ContractNamespacesListIndex = 65,
                    MemberNamesListIndex = 67,
                    MemberNamespacesListIndex = 74,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 702, // AttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 702, // AttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 702, // AttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type19.ReadAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type20.WriteAttachmentSetToXml),
                    ChildElementNamespacesListIndex = 86,
                    ContractNamespacesListIndex = 90,
                    MemberNamesListIndex = 92,
                    MemberNamespacesListIndex = 96,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 741, // UriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 741, // UriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 741, // UriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type24.ReadUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type25.WriteUriDataAttachmentToXml),
                    ChildElementNamespacesListIndex = 100,
                    ContractNamespacesListIndex = 103,
                    MemberNamesListIndex = 105,
                    MemberNamespacesListIndex = 108,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 784, // TestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 784, // TestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 784, // TestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type32.ReadTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type33.WriteTestResultMessageToXml),
                    ChildElementNamespacesListIndex = 111,
                    ContractNamespacesListIndex = 114,
                    MemberNamesListIndex = 116,
                    MemberNamespacesListIndex = 119,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 802, // TestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 802, // TestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 802, // TestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 4,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type37.ReadTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type38.WriteTestCaseToXml),
                    ChildElementNamespacesListIndex = 122,
                    ContractNamespacesListIndex = 124,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 129,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 917, // KeyValuePairOfstringstring
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 917, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 917, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type45.ReadKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type46.WriteKeyValuePairOfstringstringToXml),
                    ChildElementNamespacesListIndex = 131,
                    ContractNamespacesListIndex = 134,
                    MemberNamesListIndex = 136,
                    MemberNamespacesListIndex = 139,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 987, // DateTimeOffset
                        NamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 987, // DateTimeOffset
                        StableNameNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 987, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type47.ReadDateTimeOffsetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type48.WriteDateTimeOffsetToXml),
                    ChildElementNamespacesListIndex = 148,
                    ContractNamespacesListIndex = 151,
                    MemberNamesListIndex = 153,
                    MemberNamespacesListIndex = 156,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1049, // TestRunStats
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1049, // TestRunStats
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1049, // TestRunStats
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type49.ReadTestRunStatsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type50.WriteTestRunStatsToXml),
                    ChildElementNamespacesListIndex = 159,
                    ContractNamespacesListIndex = 162,
                    MemberNamesListIndex = 164,
                    MemberNamespacesListIndex = 167,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type54.ReadKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type55.WriteKeyValueOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 170,
                    ContractNamespacesListIndex = 173,
                    MemberNamesListIndex = 175,
                    MemberNamespacesListIndex = 178,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type56.ReadKeyValuePairOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type57.WriteKeyValuePairOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 181,
                    ContractNamespacesListIndex = 184,
                    MemberNamesListIndex = 186,
                    MemberNamespacesListIndex = 189,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1300, // LogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1300, // LogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1300, // LogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type64.ReadLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type65.WriteLogMessageToXml),
                    ChildElementNamespacesListIndex = 192,
                    ContractNamespacesListIndex = 195,
                    MemberNamesListIndex = 197,
                    MemberNamespacesListIndex = 200,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1452, // Exception
                        NamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 1452, // Exception
                        StableNameNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 1452, // Exception
                        TopLevelElementNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type69.ReadExceptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type70.WriteExceptionToXml),
                    ChildElementNamespacesListIndex = 207,
                    ContractNamespacesListIndex = 211,
                    MemberNamesListIndex = 213,
                    MemberNamespacesListIndex = 217,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1494, // KeyValueOfanyTypeanyType
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1494, // KeyValueOfanyTypeanyType
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1494, // KeyValueOfanyTypeanyType
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type74.ReadKeyValueOfanyTypeanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type75.WriteKeyValueOfanyTypeanyTypeToXml),
                    ChildElementNamespacesListIndex = 221,
                    ContractNamespacesListIndex = 224,
                    MemberNamesListIndex = 226,
                    MemberNamespacesListIndex = 229,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1549, // KeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1549, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1549, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type82.ReadKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type83.WriteKeyValueOfstringstringToXml),
                    ChildElementNamespacesListIndex = 232,
                    ContractNamespacesListIndex = 235,
                    MemberNamesListIndex = 237,
                    MemberNamespacesListIndex = 240,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1572, // PollRequest
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1572, // PollRequest
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1572, // PollRequest
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type84.ReadPollRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type85.WritePollRequestToXml),
                    ChildElementNamespacesListIndex = 243,
                    ContractNamespacesListIndex = 247,
                    MemberNamesListIndex = 249,
                    MemberNamespacesListIndex = 253,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1719, // InitializeConnectionParams
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1719, // InitializeConnectionParams
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1719, // InitializeConnectionParams
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type86.ReadInitializeConnectionParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type87.WriteInitializeConnectionParamsToXml),
                    ChildElementNamespacesListIndex = 264,
                    ContractNamespacesListIndex = 267,
                    MemberNamesListIndex = 269,
                    MemberNamespacesListIndex = 272,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1746, // StartTestRunParams
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1746, // StartTestRunParams
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1746, // StartTestRunParams
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type88.ReadStartTestRunParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type89.WriteStartTestRunParamsToXml),
                    ChildElementNamespacesListIndex = 275,
                    ContractNamespacesListIndex = 281,
                    MemberNamesListIndex = 283,
                    MemberNamespacesListIndex = 289,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1765, // TestExecutionContext
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1765, // TestExecutionContext
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1765, // TestExecutionContext
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type90.ReadTestExecutionContextFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type91.WriteTestExecutionContextToXml),
                    ChildElementNamespacesListIndex = 295,
                    ContractNamespacesListIndex = 303,
                    MemberNamesListIndex = 305,
                    MemberNamespacesListIndex = 313,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1786, // AuthenticatorTemplate
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 1786, // AuthenticatorTemplate
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 1786, // AuthenticatorTemplate
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate, Microsoft.Identity.Client, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 321,
                    ContractNamespacesListIndex = 330,
                    MemberNamesListIndex = 332,
                    MemberNamespacesListIndex = 341,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1883, // IdToken
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 1883, // IdToken
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 1883, // IdToken
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.IdToken, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 350,
                    ContractNamespacesListIndex = 359,
                    MemberNamesListIndex = 361,
                    MemberNamespacesListIndex = 370,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1891, // AuthenticationResultEx
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 1891, // AuthenticationResultEx
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 1891, // AuthenticationResultEx
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticationResultEx, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 379,
                    ContractNamespacesListIndex = 383,
                    MemberNamesListIndex = 385,
                    MemberNamespacesListIndex = 389,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1914, // AuthenticationResult
                        NamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        StableNameIndex = 1914, // AuthenticationResult
                        StableNameNamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        TopLevelElementNameIndex = 1914, // AuthenticationResult
                        TopLevelElementNamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.AuthenticationResult, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 393,
                    ContractNamespacesListIndex = 402,
                    MemberNamesListIndex = 404,
                    MemberNamespacesListIndex = 413,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2001, // User
                        NamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        StableNameIndex = 2001, // User
                        StableNameNamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        TopLevelElementNameIndex = 2001, // User
                        TopLevelElementNamespaceIndex = 1935, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                    "3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.User, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                                    "3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 422,
                    ContractNamespacesListIndex = 428,
                    MemberNamesListIndex = 430,
                    MemberNamespacesListIndex = 436,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2006, // TokenResponse
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2006, // TokenResponse
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2006, // TokenResponse
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.TokenResponse, Microsoft.Identity.Client, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 442,
                    ContractNamespacesListIndex = 455,
                    MemberNamesListIndex = 457,
                    MemberNamespacesListIndex = 470,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2020, // JsonWebToken.JWTPayload
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2020, // JsonWebToken.JWTPayload
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2020, // JsonWebToken.JWTPayload
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                    "neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTPayload, Microsoft.Identity.Client, Version=1.0.0.0, Culture=" +
                                    "neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 483,
                    ContractNamespacesListIndex = 490,
                    MemberNamesListIndex = 492,
                    MemberNamespacesListIndex = 499,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2044, // JsonWebToken.JWTHeaderWithCertificate
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2044, // JsonWebToken.JWTHeaderWithCertificate
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2044, // JsonWebToken.JWTHeaderWithCertificate
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                    ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeaderWithCertificate, Microsoft.Identity.Client, Version=1.0" +
                                    ".0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 506,
                    ContractNamespacesListIndex = 509,
                    MemberNamesListIndex = 512,
                    MemberNamespacesListIndex = 515,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2082, // JsonWebToken.JWTHeader
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2082, // JsonWebToken.JWTHeader
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2082, // JsonWebToken.JWTHeader
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.JsonWebToken+JWTHeader, Microsoft.Identity.Client, Version=1.0.0.0, Culture=n" +
                                    "eutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 518,
                    ContractNamespacesListIndex = 520,
                    MemberNamesListIndex = 522,
                    MemberNamespacesListIndex = 524,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2105, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2105, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2105, // AuthenticatorTemplate.InstanceDiscoveryResponse
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                    "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.AuthenticatorTemplate+InstanceDiscoveryResponse, Microsoft.Identity.Client, V" +
                                    "ersion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 526,
                    ContractNamespacesListIndex = 528,
                    MemberNamesListIndex = 530,
                    MemberNamespacesListIndex = 532,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2153, // UserRealmDiscoveryResponse
                        NamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        StableNameIndex = 2153, // UserRealmDiscoveryResponse
                        StableNameNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        TopLevelElementNameIndex = 2153, // UserRealmDiscoveryResponse
                        TopLevelElementNamespaceIndex = 1808, // http://schemas.datacontract.org/2004/07/Microsoft.Identity.Client.Internal
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.Identity.Client.Internal.UserRealmDiscoveryResponse, Microsoft.Identity.Client, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 534,
                    ContractNamespacesListIndex = 540,
                    MemberNamesListIndex = 542,
                    MemberNamespacesListIndex = 548,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=24
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type2.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type3.WriteArrayOfTestResultToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type4.ReadArrayOfTestResultFromXmlIsGetOnly),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type9.ReadArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type10.WriteArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type11.ReadArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                    KeyNameIndex = -1,
                    ItemNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type16.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type17.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type18.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 716, // ArrayOfUriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 716, // ArrayOfUriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 716, // ArrayOfUriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type21.ReadArrayOfUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type22.WriteArrayOfUriDataAttachmentToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type23.ReadArrayOfUriDataAttachmentFromXmlIsGetOnly),
                    CollectionItemNameIndex = 741, // UriDataAttachment
                    KeyNameIndex = -1,
                    ItemNameIndex = 741, // UriDataAttachment
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.0.10.0, Culture=neutral, Pu" +
                                    "blicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type26.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type27.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type28.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 759, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 759, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 759, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type29.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type30.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type31.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 784, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 784, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 759, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 759, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 759, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.0.10.0, Culture=neutral, Pu" +
                                    "blicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type34.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type35.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type36.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 784, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 784, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfstringFromXmlIsGetOnly),
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
                        NameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type42.ReadArrayOfKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type43.WriteArrayOfKeyValuePairOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type44.ReadArrayOfKeyValuePairOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 917, // KeyValuePairOfstringstring
                    KeyNameIndex = -1,
                    ItemNameIndex = 917, // KeyValuePairOfstringstring
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type51.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type52.WriteArrayOfKeyValueOfTestOutcomelongGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type53.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1266, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1266, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1266, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type58.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type59.WriteArrayOfTestCaseToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type60.ReadArrayOfTestCaseFromXmlIsGetOnly),
                    CollectionItemNameIndex = 802, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 802, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1282, // ArrayOfLogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1282, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1282, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type61.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type62.WriteArrayOfLogMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type63.ReadArrayOfLogMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1300, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1300, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type66.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type67.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type68.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type71.ReadArrayOfKeyValueOfanyTypeanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type72.WriteArrayOfKeyValueOfanyTypeanyTypeToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type73.ReadArrayOfKeyValueOfanyTypeanyTypeFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1494, // KeyValueOfanyTypeanyType
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1494, // KeyValueOfanyTypeanyType
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Dictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type76.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type77.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type78.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type79.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type80.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type81.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1549, // KeyValueOfstringstring
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1549, // KeyValueOfstringstring
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type92.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type93.WriteArrayOfTestResultToXml),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1266, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1266, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1266, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type94.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type95.WriteArrayOfTestCaseToXml),
                    CollectionItemNameIndex = 802, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 802, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1282, // ArrayOfLogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1282, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1282, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type96.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type97.WriteArrayOfLogMessageToXml),
                    CollectionItemNameIndex = 1300, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1300, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type98.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type99.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type100.ReadArrayOfstringFromXmlIsGetOnly),
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
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type101.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type102.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type103.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IDictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type104.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type105.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type106.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1549, // KeyValueOfstringstring
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1549, // KeyValueOfstringstring
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.HashSet`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type127.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type128.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type129.ReadArrayOfstringFromXmlIsGetOnly),
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
                        NameIndex = 2180, // ArrayOfanyType
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 2180, // ArrayOfanyType
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 2180, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
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
        // Count=4
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 630, // TestPropertyAttributes
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 630, // TestPropertyAttributes
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 630, // TestPropertyAttributes
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    IsFlags = true,
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 81,
                    MemberCount = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 944, // TestOutcome
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 944, // TestOutcome
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 944, // TestOutcome
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 142,
                    MemberCount = 5,
                    MemberListIndex = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1311, // TestMessageLevel
                        NamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        StableNameIndex = 1311, // TestMessageLevel
                        StableNameNamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        TopLevelElementNameIndex = 1311, // TestMessageLevel
                        TopLevelElementNamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 203,
                    MemberCount = 3,
                    MemberListIndex = 9,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1584, // ContractName
                        NamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1584, // ContractName
                        StableNameNamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1584, // ContractName
                        TopLevelElementNamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 257,
                    MemberCount = 6,
                    MemberListIndex = 12,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=16
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type108.WriteExceptionDetailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type107.ReadExceptionDetailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 96,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type112.WriteAuthenticatorTemplateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type111.ReadAuthenticatorTemplateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 97,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type116.WriteIdTokenToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type115.ReadIdTokenFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 98,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type120.WriteAuthenticationResultExToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type119.ReadAuthenticationResultExFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 99,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type124.WriteAuthenticationResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type123.ReadAuthenticationResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type126.WriteDateTimeOffsetToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type125.ReadDateTimeOffsetFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 100,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type131.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type130.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type132.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 101,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type136.WriteUserToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type135.ReadUserFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 102,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type140.WriteTokenResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type139.ReadTokenResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type142.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type141.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type143.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 103,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type147.WriteJsonWebToken_JWTPayloadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type146.ReadJsonWebToken_JWTPayloadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 104,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type151.WriteJsonWebToken_JWTHeaderWithCertificateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type150.ReadJsonWebToken_JWTHeaderWithCertificateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 105,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type155.WriteJsonWebToken_JWTHeaderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type154.ReadJsonWebToken_JWTHeaderFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 106,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type159.WriteAuthenticatorTemplate_InstanceDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type158.ReadAuthenticatorTemplate_InstanceDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 107,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type163.WriteUserRealmDiscoveryResponseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type162.ReadUserRealmDiscoveryResponseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 108,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type168.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type167.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type169.ReadArrayOfanyTypeFromJsonIsGetOnly),
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
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','E','x','c','e','p','t','i','o','n','D','e','t','a','i','l',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','S','e','r','v','i','c','e','M','o','d','e','l',
            '\0','A','r','r','a','y','O','f','T','e','s','t','R','e','s','u','l','t','\0','h','t','t','p',':','/','/','s','c','h','e',
            'm','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M',
            'i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t',
            'f','o','r','m','.','O','b','j','e','c','t','M','o','d','e','l','\0','T','e','s','t','R','e','s','u','l','t','\0','T','e',
            's','t','O','b','j','e','c','t','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','P','a','i','r','O','f',
            'T','e','s','t','P','r','o','p','e','r','t','y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','h','t',
            't','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/',
            '2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n',
            'e','r','i','c','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','T','e','s','t','P','r','o','p','e','r','t',
            'y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','T','e','s','t','P','r','o','p','e','r','t','y','\0',
            'T','e','s','t','P','r','o','p','e','r','t','y','A','t','t','r','i','b','u','t','e','s','\0','N','o','n','e','\0','H','i',
            'd','d','e','n','\0','I','m','m','u','t','a','b','l','e','\0','T','r','a','i','t','\0','A','r','r','a','y','O','f','A','t',
            't','a','c','h','m','e','n','t','S','e','t','\0','A','t','t','a','c','h','m','e','n','t','S','e','t','\0','A','r','r','a',
            'y','O','f','U','r','i','D','a','t','a','A','t','t','a','c','h','m','e','n','t','\0','U','r','i','D','a','t','a','A','t',
            't','a','c','h','m','e','n','t','\0','A','r','r','a','y','O','f','T','e','s','t','R','e','s','u','l','t','M','e','s','s',
            'a','g','e','\0','T','e','s','t','R','e','s','u','l','t','M','e','s','s','a','g','e','\0','T','e','s','t','C','a','s','e',
            '\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'm','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z',
            'a','t','i','o','n','/','A','r','r','a','y','s','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','P','a',
            'i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','P','a','i','r','O',
            'f','s','t','r','i','n','g','s','t','r','i','n','g','\0','T','e','s','t','O','u','t','c','o','m','e','\0','P','a','s','s',
            'e','d','\0','F','a','i','l','e','d','\0','S','k','i','p','p','e','d','\0','N','o','t','F','o','u','n','d','\0','D','a','t',
            'e','T','i','m','e','O','f','f','s','e','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','\0','T',
            'e','s','t','R','u','n','S','t','a','t','s','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f',
            't','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','C','o',
            'r','e','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f','T','e','s','t','O','u','t','c','o','m',
            'e','l','o','n','g','G','f','y','g','f','m','P','v','\0','K','e','y','V','a','l','u','e','O','f','T','e','s','t','O','u',
            't','c','o','m','e','l','o','n','g','G','f','y','g','f','m','P','v','\0','K','e','y','\0','V','a','l','u','e','\0','K','e',
            'y','V','a','l','u','e','P','a','i','r','O','f','T','e','s','t','O','u','t','c','o','m','e','l','o','n','g','G','f','y',
            'g','f','m','P','v','\0','A','r','r','a','y','O','f','T','e','s','t','C','a','s','e','\0','A','r','r','a','y','O','f','L',
            'o','g','M','e','s','s','a','g','e','\0','L','o','g','M','e','s','s','a','g','e','\0','T','e','s','t','M','e','s','s','a',
            'g','e','L','e','v','e','l','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n',
            't','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','V','i',
            's','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','O','b','j','e','c','t',
            'M','o','d','e','l','.','L','o','g','g','i','n','g','\0','I','n','f','o','r','m','a','t','i','o','n','a','l','\0','W','a',
            'r','n','i','n','g','\0','E','r','r','o','r','\0','E','x','c','e','p','t','i','o','n','\0','A','r','r','a','y','O','f','K',
            'e','y','V','a','l','u','e','O','f','a','n','y','T','y','p','e','a','n','y','T','y','p','e','\0','K','e','y','V','a','l',
            'u','e','O','f','a','n','y','T','y','p','e','a','n','y','T','y','p','e','\0','A','r','r','a','y','O','f','K','e','y','V',
            'a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','O','f','s',
            't','r','i','n','g','s','t','r','i','n','g','\0','P','o','l','l','R','e','q','u','e','s','t','\0','C','o','n','t','r','a',
            'c','t','N','a','m','e','\0','M','i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.',
            'T','e','s','t','P','l','a','t','f','o','r','m','.','C','o','r','e','\0','C','a','n','c','e','l','T','e','s','t','R','u',
            'n','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n','e','c','t','i','o','n','\0','S','h','u','t','d','o','w',
            'n','\0','S','t','a','r','t','T','e','s','t','R','u','n','\0','S','t','a','r','t','T','e','s','t','R','u','n','W','i','t',
            'h','S','o','u','r','c','e','s','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n','e','c','t','i','o','n','P',
            'a','r','a','m','s','\0','S','t','a','r','t','T','e','s','t','R','u','n','P','a','r','a','m','s','\0','T','e','s','t','E',
            'x','e','c','u','t','i','o','n','C','o','n','t','e','x','t','\0','A','u','t','h','e','n','t','i','c','a','t','o','r','T',
            'e','m','p','l','a','t','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n',
            't','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','I','d',
            'e','n','t','i','t','y','.','C','l','i','e','n','t','.','I','n','t','e','r','n','a','l','\0','I','d','T','o','k','e','n',
            '\0','A','u','t','h','e','n','t','i','c','a','t','i','o','n','R','e','s','u','l','t','E','x','\0','A','u','t','h','e','n',
            't','i','c','a','t','i','o','n','R','e','s','u','l','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'd','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o',
            's','o','f','t','.','I','d','e','n','t','i','t','y','.','C','l','i','e','n','t','\0','U','s','e','r','\0','T','o','k','e',
            'n','R','e','s','p','o','n','s','e','\0','J','s','o','n','W','e','b','T','o','k','e','n','.','J','W','T','P','a','y','l',
            'o','a','d','\0','J','s','o','n','W','e','b','T','o','k','e','n','.','J','W','T','H','e','a','d','e','r','W','i','t','h',
            'C','e','r','t','i','f','i','c','a','t','e','\0','J','s','o','n','W','e','b','T','o','k','e','n','.','J','W','T','H','e',
            'a','d','e','r','\0','A','u','t','h','e','n','t','i','c','a','t','o','r','T','e','m','p','l','a','t','e','.','I','n','s',
            't','a','n','c','e','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n','s','e','\0','U','s','e','r','R','e','a',
            'l','m','D','i','s','c','o','v','e','r','y','R','e','s','p','o','n','s','e','\0','A','r','r','a','y','O','f','a','n','y',
            'T','y','p','e','\0','H','e','l','p','L','i','n','k','\0','I','n','n','e','r','E','x','c','e','p','t','i','o','n','\0','M',
            'e','s','s','a','g','e','\0','S','t','a','c','k','T','r','a','c','e','\0','T','y','p','e','\0','P','r','o','p','e','r','t',
            'i','e','s','\0','A','t','t','a','c','h','m','e','n','t','s','\0','M','e','s','s','a','g','e','s','\0','k','e','y','\0','v',
            'a','l','u','e','\0','A','t','t','r','i','b','u','t','e','s','\0','C','a','t','e','g','o','r','y','\0','D','e','s','c','r',
            'i','p','t','i','o','n','\0','I','d','\0','L','a','b','e','l','\0','V','a','l','u','e','T','y','p','e','\0','D','i','s','p',
            'l','a','y','N','a','m','e','\0','U','r','i','\0','T','e','x','t','\0','D','a','t','e','T','i','m','e','\0','O','f','f','s',
            'e','t','M','i','n','u','t','e','s','\0','E','x','e','c','u','t','e','d','T','e','s','t','s','\0','S','t','a','t','s','\0',
            'M','e','s','s','a','g','e','L','e','v','e','l','\0','D','a','t','a','\0','S','o','u','r','c','e','\0','C','o','n','t','r',
            'a','c','t','\0','I','n','i','t','P','a','r','a','m','s','\0','T','e','s','t','R','u','n','P','a','r','a','m','s','\0','L',
            'o','a','d','O','n','l','y','W','e','l','l','K','n','o','w','n','E','x','t','e','n','s','i','o','n','s','\0','P','a','t',
            'h','T','o','A','d','d','i','t','i','o','n','a','l','E','x','t','e','n','s','i','o','n','s','\0','D','a','t','a','C','o',
            'l','l','e','c','t','o','r','S','e','r','v','i','c','e','U','r','i','\0','E','x','e','c','u','t','i','o','n','C','o','n',
            't','e','x','t','\0','S','o','u','r','c','e','s','\0','T','e','s','t','R','u','n','S','e','t','t','i','n','g','s','\0','T',
            'e','s','t','s','\0','A','r','e','T','e','s','t','C','a','s','e','L','e','v','e','l','E','v','e','n','t','s','R','e','q',
            'u','i','r','e','d','\0','F','r','e','q','u','e','n','c','y','O','f','R','u','n','S','t','a','t','s','C','h','a','n','g',
            'e','E','v','e','n','t','\0','I','n','I','s','o','l','a','t','i','o','n','\0','I','s','D','e','b','u','g','\0','K','e','e',
            'p','A','l','i','v','e','\0','R','u','n','S','t','a','t','s','C','h','a','n','g','e','E','v','e','n','t','T','i','m','e',
            'o','u','t','\0','T','e','s','t','C','a','s','e','F','i','l','t','e','r','\0','A','u','t','h','o','r','i','t','y','\0','A',
            'u','t','h','o','r','i','z','e','E','n','d','p','o','i','n','t','\0','D','e','v','i','c','e','C','o','d','e','E','n','d',
            'p','o','i','n','t','\0','H','o','s','t','\0','I','n','s','t','a','n','c','e','D','i','s','c','o','v','e','r','y','E','n',
            'd','p','o','i','n','t','\0','I','s','s','u','e','r','\0','T','o','k','e','n','E','n','d','p','o','i','n','t','\0','U','s',
            'e','r','R','e','a','l','m','E','n','d','p','o','i','n','t','\0','h','o','m','e','_','o','i','d','\0','i','s','s','\0','n',
            'a','m','e','\0','o','i','d','\0','p','r','e','f','e','r','r','e','d','_','u','s','e','r','n','a','m','e','\0','s','u','b',
            '\0','t','i','d','\0','v','e','r','\0','R','e','f','r','e','s','h','T','o','k','e','n','\0','R','e','s','u','l','t','\0','U',
            's','e','r','A','s','s','e','r','t','i','o','n','H','a','s','h','\0','E','x','p','i','r','e','s','O','n','\0','F','a','m',
            'i','l','y','I','d','\0','S','c','o','p','e','S','e','t','\0','T','e','n','a','n','t','I','d','\0','T','o','k','e','n','\0',
            'T','o','k','e','n','T','y','p','e','\0','D','i','s','p','l','a','y','a','b','l','e','I','d','\0','H','o','m','e','O','b',
            'j','e','c','t','I','d','\0','I','d','e','n','t','i','t','y','P','r','o','v','i','d','e','r','\0','N','a','m','e','\0','U',
            'n','i','q','u','e','I','d','\0','a','c','c','e','s','s','_','t','o','k','e','n','\0','c','o','r','r','e','l','a','t','i',
            'o','n','_','i','d','\0','e','r','r','o','r','\0','e','r','r','o','r','_','c','o','d','e','s','\0','e','r','r','o','r','_',
            'd','e','s','c','r','i','p','t','i','o','n','\0','e','x','p','i','r','e','s','_','i','n','\0','f','o','c','i','\0','i','d',
            '_','t','o','k','e','n','\0','i','d','_','t','o','k','e','n','_','e','x','p','i','r','e','s','_','i','n','\0','r','e','f',
            'r','e','s','h','_','t','o','k','e','n','\0','s','c','o','p','e','\0','t','o','k','e','n','_','t','y','p','e','\0','a','u',
            'd','\0','e','x','p','\0','j','t','i','\0','n','b','f','\0','a','l','g','\0','k','i','d','\0','t','e','n','a','n','t','_','d',
            'i','s','c','o','v','e','r','y','_','e','n','d','p','o','i','n','t','\0','a','c','c','o','u','n','t','_','t','y','p','e',
            '\0','f','e','d','e','r','a','t','i','o','n','_','a','c','t','i','v','e','_','a','u','t','h','_','u','r','l','\0','f','e',
            'd','e','r','a','t','i','o','n','_','m','e','t','a','d','a','t','a','_','u','r','l','\0','f','e','d','e','r','a','t','i',
            'o','n','_','p','r','o','t','o','c','o','l','\0'};
    }
}
