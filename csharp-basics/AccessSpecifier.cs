using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace csharp_basics
{
    public class AccessSpecifier
    {
    }

    public class FiatEngine
    {
        public string EngineSource = "Fiat";
        public string EngineModel = "Multi Jet";
        protected void Start() {
            Console.WriteLine("engine started");
        }
        public void Stop()
        {
            Console.WriteLine("engine stoped");
        }
    }

    public class MarutiSwift : FiatEngine
    {
        public void StartEngine()
        {
            Start();
        }
    }
}
