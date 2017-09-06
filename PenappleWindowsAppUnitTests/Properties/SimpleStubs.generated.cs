using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace PenappleWindowsApp
{
    [CompilerGenerated]
    public class StubIAsyncInitialization : IAsyncInitialization
    {
        private readonly StubContainer<StubIAsyncInitialization> _stubs = new StubContainer<StubIAsyncInitialization>();

        global::System.Threading.Tasks.Task global::PenappleWindowsApp.IAsyncInitialization.Initialization
        {
            get
            {
                return _stubs.GetMethodStub<Initialization_Get_Delegate>("get_Initialization").Invoke();
            }
        }

        public delegate global::System.Threading.Tasks.Task Initialization_Get_Delegate();

        public StubIAsyncInitialization Initialization_Get(Initialization_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace PenscribCommon.Models
{
    [CompilerGenerated]
    public class StubIModel : IModel
    {
        private readonly StubContainer<StubIModel> _stubs = new StubContainer<StubIModel>();

        string global::PenscribCommon.Models.IModel.id
        {
            get
            {
                return _stubs.GetMethodStub<id_Get_Delegate>("get_id").Invoke();
            }

            set
            {
                _stubs.GetMethodStub<id_Set_Delegate>("set_id").Invoke(value);
            }
        }

        global::PenscribCommon.Models.ModelName global::PenscribCommon.Models.IModel.type
        {
            get
            {
                return _stubs.GetMethodStub<type_Get_Delegate>("get_type").Invoke();
            }
        }

        public delegate string id_Get_Delegate();

        public StubIModel id_Get(id_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void id_Set_Delegate(string value);

        public StubIModel id_Set(id_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate global::PenscribCommon.Models.ModelName type_Get_Delegate();

        public StubIModel type_Get(type_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}