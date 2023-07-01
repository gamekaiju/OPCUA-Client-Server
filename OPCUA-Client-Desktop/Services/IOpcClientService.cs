using System.Collections.Generic;

namespace OPCUA_Client_Desktop.Services;

public interface IOpcClientService
{
    bool IsConnected { get; }
    void Connect();
    void Disconnect();
    List<string> Fetch();
}
