/*
* No puedo enviar correos desde .net, se envia a veces si, a veces no. Error: net_io_connectionclosed
* I can't send mail from .net, it sends sometimes yes, sometimes no. Error: net_io_connectionclosed
*/

//Solución:
//Update in Office365 SMTP TLS 

System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

//net framework 4.0
System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2, 768: //TLS 1.1