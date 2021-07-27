# FDP-Drone
#Descriere
Cu toții știm că în ziua de astăzi traficul este o mare problemă, mai ales când vine vorba de accidente, așa că ne-am gândit să venim cu o solutie la acestă problemă. Drona FDP (firefighter, doctor, police) pe care am dezvoltat-o, este capabilă să evite un posibil trafic de autoturisme, și să ajungă mai repede la fața unui accident pentru a analiza situația în detalii și pentru a ajuta posibile victime, înaintea autoritaților.
Drona este dotată cu o trusă de prim ajutor, o cameră termală pentru a ajuta la găsirea unor posibili supraviețuitori în caz de cutremure, se poate monta o bila anti-foc, o stație radio pentru a comunica cu posibile persoane aflate în pericol, o cameră de tip "GoPro" care trimite imagini în timp real cu ajutorul unui modul de transmitere video FPV, iar pe viitor vom adăuga un sistem prin care drona să poata să recunoască posibili infractori cautați de autoritați cu ajutorul inteligenței artificiale (recunoaștere facială). În curând va fi gata și sitemul de mapare GPS pentru funcțioanrea autonomă a dronei.

#Descriere tehnică
Drona vine echipată cu:
* cadru hexacopter
* flight controller dezvoltat cu o placa "Arduino Uno" (micro controller "ATmega328P", gyroscop "GY-521", GPS "U-blox Neo-6M", reciever radio "FSIA6B" - 4 canale) + interfața user pentru gestionarea datelor de la sol (FlightMonitor)
* "RaspberryPi 4" + camera termala
* cameră de tip "GoPro" + convertor hdmi la analog + modul transmitere video FPV
* motare brushless BR2212 980kv 
* esc-uri 30A (electronic speed controllers)
* acumulatori "LiPo" 3S 10000mAh (autonomie 20 min)In atentia utilizatorului:

#Librării folosite
Sunt folosite librăriile:
"AltSoftSerial" dezvoltată de Paul Stoffregen si "TinyGPS" dezvoltată de Mikal Hart.

#Necesitați
* Windows 10
* .NET Framework 4.7.2
* Arduino IDE 1.8.15 + Arduino Uno

#Creatori/Autori:
* Spulber George-Marian: Hardware + FlightMonitor developer
* Maftei Albert-Alexandru Hardware + Flight Controller devoloper