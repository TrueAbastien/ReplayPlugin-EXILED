using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAPI = Exiled.API.Features;

namespace ReplayPlugin.Handlers
{
    class Server
    {
        internal void OnStarting()
        {
            EAPI.Map.TurnOffAllLights(5f);
        }
    }
}
