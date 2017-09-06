using System.Reflection;



namespace __InterfaceProxies
{
	public class ServiceChannelProxy_IUniversalTestExecutorService : System.ServiceModel.Channels.ServiceChannelProxy_P, Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P
	{
		Microsoft.VisualStudio.TestPlatform.Core.PollRequest_P Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.PollForRequest()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			Microsoft.VisualStudio.TestPlatform.Core.PollRequest_P retval = ((Microsoft.VisualStudio.TestPlatform.Core.PollRequest_P)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		void Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.TestConnection(System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult_P> dummyTestResults)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					dummyTestResults
			};
			base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							);
		}

		void Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.OnTestRunChange(
					Microsoft.VisualStudio.TestPlatform.Core.TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult_P> newTestResults)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					testRunStats, 
					newTestResults
			};
			base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							);
		}

		void Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.OnTestRunChanges(
					Microsoft.VisualStudio.TestPlatform.Core.TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult_P> newTestResults, 
					System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase_P> inProgressTestCases)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					testRunStats, 
					newTestResults, 
					inProgressTestCases
			};
			base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							);
		}

		void Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.OnLogMessages(System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.Core.LogMessage_P> messages)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					messages
			};
			base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							);
		}

		void Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.OnRunComplete(
					bool isCanceled, 
					bool isAborted, 
					System.Collections.Generic.ICollection_P<string> executorUris, 
					System.Exception_P exception, 
					Microsoft.VisualStudio.TestPlatform.Core.TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult_P> lastChunk, 
					bool adapterHintedToShutdownAfterRun, 
					System.TimeSpan_P elapsedTime, 
					System.Collections.Generic.ICollection_P<Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet_P> runContextAttachments)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					isCanceled, 
					isAborted, 
					executorUris, 
					exception, 
					testRunStats, 
					lastChunk, 
					adapterHintedToShutdownAfterRun, 
					elapsedTime, 
					runContextAttachments
			};
			base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							);
		}

		int Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P.LaunchProcessWithDebuggerAttached(
					string filePath, 
					string workingDirectory, 
					string arguments, 
					System.Collections.Generic.IDictionary_P<string, string> environmentVariables)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					filePath, 
					workingDirectory, 
					arguments, 
					environmentVariables
			};
			int retval = ((int)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	[global::System.Runtime.CompilerServices.ModuleConstructor]
	[global::System.Runtime.CompilerServices.DependencyReductionRoot]
	public static class __DispatchProxyImplementationData
	{
		static global::System.Reflection.DispatchProxyEntry[] s_entryTable = new global::System.Reflection.DispatchProxyEntry[] {
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService_P).TypeHandle,
					ImplementationClassType = typeof(ServiceChannelProxy_IUniversalTestExecutorService).TypeHandle,
				}
		};
		static __DispatchProxyImplementationData()
		{
			global::System.Reflection.DispatchProxyHelpers.RegisterImplementations(s_entryTable);
		}
	}
}

namespace Microsoft.VisualStudio.TestPlatform.Core
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.Core.IUniversalTestExecutorService, Microsoft.VisualStudio.TestPlatform.Core" +
		", Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public interface IUniversalTestExecutorService_P
	{
		PollRequest_P PollForRequest();

		void TestConnection(System.Collections.Generic.IEnumerable_P<ObjectModel.TestResult_P> dummyTestResults);

		void OnTestRunChange(
					TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<ObjectModel.TestResult_P> newTestResults);

		void OnTestRunChanges(
					TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<ObjectModel.TestResult_P> newTestResults, 
					System.Collections.Generic.IEnumerable_P<ObjectModel.TestCase_P> inProgressTestCases);

		void OnLogMessages(System.Collections.Generic.IEnumerable_P<LogMessage_P> messages);

		void OnRunComplete(
					bool isCanceled, 
					bool isAborted, 
					System.Collections.Generic.ICollection_P<string> executorUris, 
					System.Exception_P exception, 
					TestRunStats_P testRunStats, 
					System.Collections.Generic.IEnumerable_P<ObjectModel.TestResult_P> lastChunk, 
					bool adapterHintedToShutdownAfterRun, 
					System.TimeSpan_P elapsedTime, 
					System.Collections.Generic.ICollection_P<ObjectModel.AttachmentSet_P> runContextAttachments);

		int LaunchProcessWithDebuggerAttached(
					string filePath, 
					string workingDirectory, 
					string arguments, 
					System.Collections.Generic.IDictionary_P<string, string> environmentVariables);
	}
}

namespace System.ServiceModel.Channels
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.ServiceModel.Channels.ServiceChannelProxy, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral," +
		" PublicKeyToken=b03f5f7f11d50a3a")]
	public class ServiceChannelProxy_P : global::System.Reflection.DispatchProxy
	{
		protected override object Invoke(
					global::System.Reflection.MethodInfo targetMethodInfo, 
					object[] args)
		{
			return null;
		}
	}
}

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Reflection.DispatchProxy, System.Private.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class DispatchProxy_P
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.Core
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
		", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class PollRequest_P
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
		"sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class TestResult_P
	{
	}
}

namespace System.Collections.Generic
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
		"en=b03f5f7f11d50a3a")]
	public interface IEnumerable_P<T>
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.Core
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
		"0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class TestRunStats_P
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
		"on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class TestCase_P
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.Core
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
		" Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class LogMessage_P
	{
	}
}

namespace System.Collections.Generic
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
		"en=b03f5f7f11d50a3a")]
	public interface ICollection_P<T>
	{
	}
}

namespace System
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class Exception_P
	{
	}
}

namespace System
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.TimeSpan, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public struct TimeSpan_P
	{
	}
}

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel
{
	[global::System.Runtime.InteropServices.McgRedirectedType("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
		"Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class AttachmentSet_P
	{
	}
}

namespace System.Collections.Generic
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Collections.Generic.IDictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
		"en=b03f5f7f11d50a3a")]
	public interface IDictionary_P<TKey, TValue>
	{
	}
}
