using System.Diagnostics;

namespace PrototypeV1.Controllers
{
    public class ProcessController
    {
        private static ProcessController instance = new ProcessController();
        public static ProcessController Instance { get { return instance; } }

        public Process[] GetEveClients()
        {  
            return Process.GetProcessesByName("exefile");
        }
    }
}
