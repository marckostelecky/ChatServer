using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Photon.SocketServer;

public class ChatServer : ApplicationBase
{
    protected override PeerBase CreatePeer(InitRequest initRequest)
    {
        return new ChatPeer(initRequest);
    }

    protected override void Setup()
    {

    }

    protected override void TearDown()
    {

    }
}
