---
{
"Title": "Systemanforderungen GRIPS G5", "Tags": "Hilfe"
}
---

# Systemanforderungen GRIPS Version: G5


**Aufgrund der individuellen IT-Landschaften und unterschiedlichen Anwendungsbereichen, verwendeten Module und Zusatzkomponenten können die nachfolgenden Angaben nur eine grobe Einschätzung darstellen. (Die Mindestanforderungen sind alle ohne Gewähr).** 

![bild](https://docs.recom.eu/images/69c90bfb-421f-4bba-b92e-dbfb5146d38e.png)

### Datenbankserver:

* Datenbank: MSSQL 2012 oder höher

* 2 Datenbanken (je eine für Produktiv- und Testumgebung)

* CPU: 4 Core 2,4 GHz oder höher

* z.B. Intel Xeon CPU E5 2440 v2 oder vergleichbarer CPU

* Betriebssystem: Windows Server 2012 R2 64Bit oder höher

* Datenbank Standard Collection: Latin 1_General_CI_AS

* .Net Version: 4.7 oder höher

* RAM: 16 GB oder höher

* Festplattenspeicher: Festplatte skalierbar, mind. 256 GB HHD

* User-Berechtigung: Administrator


Der Datenbankserver sollte allein nur für die GriPS Datenbank zur Verfügung stehen.

Eine MSSQL Server Express Version wird nicht empfohlen, aufgrund Speicherlimitierung.

Ein Zugriff auf das MSSQL Studio für den RECOM-Support muss vorhanden sein.


### Terminalserver:

* CPU: 4 Core 2,4 GHz oder höher

* z.B. Intel Xeon CPU E5 2440 v2 oder vergleichbarer CPU

* Betriebssystem: Windows Server 2012 R2 64Bit oder höher

* .Net Version: 4.7 oder höher

* VS2017 C++ Redistributable:

* RAM: mind. 16 GB oder höher bei 5 Usern gleichzeitig auf dem System, für jeden weiteren plus 2 GB RAM

* Festplattenspeicher: 256 GB HHD oder höher

* User pro APP-Server: basierend auf den vorhandenen Hardwareressourcen, z.B. 4 User = 16 GB Ram, CPU 4 Core, HHD 200GB

* Display-Auflösung: 1920x1080

* User-Berechtigung: Administrator


### Client-PC:

* CPU: 2 Core mit mind. 2 GHz

* Betriebssystem: Windows 10 64Bit oder höher

* .Net Version: 4.7 oder höher

* VS2017 C++ Redistributable

* RAM: mind. 8 GB

* Festplattenspeicher:

* Display-Auflösung: 1920x1080


### RDP:

* CPU: 2 Core mit 1GHz

* Betriebssystem: Windows 10 64Bit oder höher

* RDP Version: 10.0.19041.1266 oder höher

* .Net Version: 4.7 oder höher

* VS2017 C++ Redistributable

* RAM: mind. 2GB

* Display-Auflösung: 1920x1080

Bandbreite bei Cloud-Anbindung: mind. 25mbit oder höher

Bei gleichzeitiger Nutzung mehrerer Clients muss die Bandbreite erhöht werden.


