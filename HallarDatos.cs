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
