using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenappleWindowsApp
{
    public static class Globals
    {
        public static string AadInstance = "https://login.microsoftonline.com/tfp/";
        public static string Tenant = "inkwellcalpoly.onmicrosoft.com/";
        public static string ClientId = "2f9e6ab6-cd48-4232-9030-b49814d2a5b3";
        public static string SignInRegisterPolicy = "B2C_1_inkwell_signin/";
        public static string[] DefaultScopes = new string[]
        {
            "https://inkwellcalpoly.onmicrosoft.com/auth/messages"
        };

        public static string Authority = string.Concat(AadInstance, Tenant, SignInRegisterPolicy);
    }
}
