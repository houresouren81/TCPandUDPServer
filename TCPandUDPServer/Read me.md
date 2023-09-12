# ** Befattning om min Application**


## TCP Transmission Control Protocol , UDP  User Datagram Protocol
 En console application som �r byggd p� C# spr�k 
som visar hur Client och Server snackar med varandra via 2 protocol TCP och UDP.

## Code
Jag skapade 4 classer :
1. TCPServer
2. UDPServer
3. Client
4. Settings


### I TCPServer classen
Har en method runTCPServer() funkar s� h�r:
- Client identifiera server och IP adress och sen v�ljer port nr som finns 2 variables i Settings classen.
- Server lyssnar p� porten.
- Client initiera en anslutning (skicka syn paket).
- Server Accpterar anslutningen och skickar syn ack paket.
- NU Client och Server snackar och skickar data till varandra.
- Allt klart nu st�nger Client/Server anslutningen.
- I TCP server anv�nder vi 3 handshake teknink.

### I UDPServer classen
Har en method runUDPServer() funkar s� h�r:
- Client identifiera server och IP adress och sen v�ljer port nr som finns 2 variables i Settings classen.
- Server lyssnar p� porten .
- Server accpterar anslutningen **UTAN** att skicka n�t bekr�ftelse .
- Client skickar paket. 
- Beh�ver inte st�nga anslutningen.



### I Client classen 
Har tv� methodr SendTcpMessage och SendUdpMessage som funkar s� h�r:
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
 1. H�r jag fixade input f�lt som du v�ljer TCP eller UDP server ,
  och sen anropa methoden beroande p� inputen.
 2. Lagt if condition om 1 s� TCP sever ska vara ON och ,
	sen man v�ljer nr 3 s� genom Client Tcp message skickar meddelandet.

 3. Om man knappar in 2 som input s� UDP server ska vara ON ,
	sen man v�ljer nr 4 s� genom Client UDP message skickar meddelandet.






