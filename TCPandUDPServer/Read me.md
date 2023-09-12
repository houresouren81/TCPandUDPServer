# ** Befattning om min Application**


## TCP Transmission Control Protocol , UDP  User Datagram Protocol
 En console application som är byggd på C# språk 
som visar hur Client och Server snackar med varandra via 2 protocol TCP och UDP.

## Code
Jag skapade 4 classer :
1. TCPServer
2. UDPServer
3. Client
4. Settings


### I TCPServer classen
Har en method runTCPServer() funkar så här:
- Client identifiera server och IP adress och sen väljer port nr som finns 2 variables i Settings classen.
- Server lyssnar på porten.
- Client initiera en anslutning (skicka syn paket).
- Server Accpterar anslutningen och skickar syn ack paket.
- NU Client och Server snackar och skickar data till varandra.
- Allt klart nu stänger Client/Server anslutningen.
- I TCP server använder vi 3 handshake teknink.

### I UDPServer classen
Har en method runUDPServer() funkar så här:
- Client identifiera server och IP adress och sen väljer port nr som finns 2 variables i Settings classen.
- Server lyssnar på porten .
- Server accpterar anslutningen **UTAN** att skicka nåt bekräftelse .
- Client skickar paket. 
- Behöver inte stänga anslutningen.



### I Client classen 
Har två methodr SendTcpMessage och SendUdpMessage som funkar så här:
1- SendTcpMessage(string message)
Tar emot message typ string och skickar ett meddelandet till TCP server.
2- SendUdpMessage(string message)
Tar emot message type string och skickar ett meddelandet till UDP server.

### I Settings classen
Lagt 2 variables 2 portar till TCP och UDP. 
TCP och UDP server har arv funkation fr Settings classen.

` public const int UDP_PORT = 5001;
  public const int TCP_PORT = 5000;`


  ### Program
 1. Här jag fixade input fält som du väljer TCP eller UDP server ,
  och sen anropa methoden beroande på inputen.
 2. Lagt if condition om 1 så TCP sever ska vara ON och ,
	sen man väljer nr 3 så genom Client Tcp message skickar meddelandet.

 3. Om man knappar in 2 som input så UDP server ska vara ON ,
	sen man väljer nr 4 så genom Client UDP message skickar meddelandet.






