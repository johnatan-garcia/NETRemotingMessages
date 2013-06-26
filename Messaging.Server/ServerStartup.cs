using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Messaging.Server {
    
    class ServerStartup {
        
        static void Main(string[] args) {
            HttpChannel chnl = new HttpChannel(1234);
            ChannelServices.RegisterChannel(chnl, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CustomerManager), "CustomerManager.soap", WellKnownObjectMode.Singleton);
            // the server will keep running until keypress.
            Console.ReadLine();
        }
    }

}
