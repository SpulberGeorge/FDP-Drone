# FDP-Drone

Descriere:
* Cu toții știm că în ziua de astăzi traficul este o mare problemă, mai ales când vine vorba de accidente, așa că ne-am gândit să venim cu o solutie la acestă problemă. Drona FDP (firefighter, doctor, police) pe care am dezvoltat-o, este capabilă să evite un posibil trafic de autoturisme, și să ajungă mai repede la fața unui accident pentru a analiza situația în detalii și pentru a ajuta posibile victime, înaintea autoritaților.
* Drona este dotată cu o trusă de prim ajutor, o cameră termală pentru a ajuta la găsirea unor posibili supraviețuitori în caz de cutremure, se poate monta o bila anti-foc, o stație radio pentru a comunica cu posibile persoane aflate în pericol, o cameră de tip "GoPro" care trimite imagini în timp real cu ajutorul unui modul de transmitere video FPV, iar pe viitor vom adăuga un sistem prin care drona să poata să recunoască posibili infractori cautați de autoritați cu ajutorul inteligenței artificiale (recunoaștere facială). În curând va fi gata și sitemul de mapare GPS pentru funcțioanrea autonomă a dronei.

Descriere tehnică:
* Grade de libertate: X, Y, Z
* Giroscop folosit pentru determinarea unghiului de înclinare + pentru menținerea dronei pe poziția zero cu ajutorul PID-ului (protocol I2C)
* Modul GPS pentru a determina locația dronei + obținerea unor coordonate precise
* Microcontroler "ATmega328P" + Raspberry Pi ușor de implementat
* Control telecomandat + autonom (cod custom)
* Aplicatie C# cu user interface pentru a comunica cu drona de la sol, observarea si gestionarea datelor (comunicatie serial - FlightMonitor)
* Desing robust, dimensiune medie, ușor de gestionat

Dotări:
* Cadru hexacopter
* Flight controller "Arduino Uno/Nano" (microcontroller "ATmega328P", giroscop "GY-521", GPS "U-blox Neo-6M", reciever radio "FSIA6B" - 4 canale) + interfața user pentru gestionarea datelor de la sol (FlightMonitor)
* "RaspberryPi 4" + camera termala
* Cameră de tip "GoPro" + convertor hdmi la analog + modul transmitere video FPV
* x6 motare brushless BR2212 980kv + elice 10 inch
* Esc-uri 30A (electronic speed controllers)
* Acumulatori "LiPo" 3S 10000mAh (autonomie 20 min)

Librării folosite:
* "AltSoftSerial" dezvoltată de Paul Stoffregen
* "TinyGPS" dezvoltată de Mikal Hart.

Necesitați/Cerințe de sistem:
* Windows 10
* .NET Framework 4.7.2
* Arduino IDE 1.8.15

Creatori/Autori:
* Spulber George-Marian: Hardware + FlightMonitor developer
* Maftei Albert-Alexandru Hardware + Flight Controller devoloper