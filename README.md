# NorbitsChallenge

Dette er mitt forsøk på en utfordring sendt fra Norbits AS i forbindelse med en mulig ansettelse.

## Oppgavebeskrivelse:
NorbitsChallenge er ein ASP.NET Core webapplikasjon oppretta i Visual Studio 2017. 
NorbitsChallenge er tiltenkt å late tilsette på verkstadar slå opp informasjon om bilar knytt til sin verkstad. 
Autentisering er utelatt frå denne versjonen for forenkling. 

Me ønskjer følgjande utviding av applikasjonen:

* Vise alle bilar knytt til verkstaden i ei liste
* Vise alle data frå biltabellen på oppsøkt bil
* Leggje til ny bil og slette bil
* Redigere data på ein bil

Me ønskjer også at du peikar på openbare problem med applikasjonen og løyser desse. Me vil ikkje leggje særleg vekt på det grafiske utover fornuftig bruk av html/javascript/css, så ikkje legg for mykje tid i det.

Visual Studio Community kan lastast ned gratis hjå Microsoft: https://visualstudio.microsoft.com/vs/community/
Database i denne løysinga er localdb, du peikar sjølv til rett stad i appsettings.json

Last ned kildekoden til din maskin og last opp til eigen github-profil eller send oss ein link når du er ferdig. Ikkje send pull request til dette repoet, då vil koden din vere tilgjengeleg for eventuelle andre kandidatar.

Lukke til!


## Beskrivelse av gjennomføring
Etter å ha mottatt linken til oppgaven brukte jeg den første dagen til å sette meg inn i de forskjellige filene. Det var desverre noen av filene som manglet. 
Først oppdaget jeg at selve mdf og ldf filene manglet, altså databasefilene. Jeg opprettet basert på informasjonen jeg fant fra filene egen databasefil, og supplerte med ekstra info da Norbits oppdaterte filene sine.
Jeg oppdaget også at Onobtrusive-ajax var blitt refrert til i filene, men de manglet. Dette hentet jeg inn ved å bruke kommandoen: npm install jquery-ajax-unobtrusive
Etter at alt av filer som manglet var på plass startet jeg å prøve å besvare de fire oppgavene. Jeg valgte også å gjøre en endring slik at når man kommer til hovedsiden kan man flytte seg til enten innstillinger eller oversikt over biler. Det var i oversikt over biler jeg hadde som mål å utføre de fire forskjellige oppgavene. Desverre har jeg kun i varierende grad besvart tre av de fire.
Jeg håper dette forsøket viser at jeg har grunnkunnskapen innen ASP.NET utvikling, men at en ansettelse hos Norbits AS vil gi meg muligheten til å kunne bli enda bedre.