/*
* Cuando el administrador de paquetes NuGet de Visual Studio tiene fallas como por ejemplo que no carga, 
* correr esto en la consola de administrador de paquetes de Visual Studio:
* [Net.ServicePointManager]::SecurityProtocol=[Net.ServicePointManager]::SecurityProtocol-bOR [Net.SecurityProtocolType]::Tls12
*/
public static string BuscarDireccionIP()
{
    IPAddress DirIP=null;
    string hostName = Dns.GetHostName();
    IPHostEntry local = Dns.GetHostEntry(hostName);
    foreach (IPAddress ipaddress in local.AddressList)
    {
        if (ipaddress.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork)
        {
        	DirIP = ipaddress;
            break;
        }
    }
    return DirIP.ToString();
}

public string BuscarNombreEquipo()
{
    string strHostName = string.Empty;
    strHostName = Dns.GetHostName();
    return strHostName;
}
