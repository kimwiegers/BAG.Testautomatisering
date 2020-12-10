Functionaliteit: BagUpdate


Abstract Scenario: Een wegvak valt na de BAG update onder een nieuwe gemeente
Achtergrond: De begrenzing van een gemeente is aangepast. 

Gegeven een gebruiker de grens van de gemeente '<oude gemeente>' heeft aangepast waardoor het wegvak met id <wegvak id> onder gemeente '<nieuwe gemeente>' komt te vallen
En het wegvak verschuift door de aanpassing van de straat '<oude straat>' in '<oude gemeente>' naar '<nieuwe straat>' in '<nieuwe gemeente>'
En '<wegbeheerder>' is de wegbeheerder
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database

Voorbeelden: 

| oude gemeente | wegvak id | nieuwe gemeente | oude straat      | nieuwe straat    | wegbeheerder |
| Kopenhagen    | 999999998 | Tirana          | Academiestraat_N | Academiestraat_N | de gemeente  |
| Kopenhagen    | 999999997 | Tirana          | Academiestraat_N | Academiestraat_N | de gemeente  |
| Kopenhagen    | 999999996 | Tirana          | Academiestraat_B | Academiestraat_N | de gemeente  |
| Kopenhagen    | 999999995 | Tirana          | Academiestraat_B | Academiestraat_N | Berlijn      |
| Kopenhagen    | 999999994 | Tirana          | Academiestraat_B | Academiestraat_N | Sofia        |
| Tallinn       | 999999988 | Tirana          | Academiestraat_B | Academiestraat_N | de provincie |

Scenario: Een wegvak ligt na de BAG upddte in een onbekende gemeente
Achtergrond: De nieuwe gemeente is niet bekend in BAG

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999993 onder on onbekende gemeente komt te vallen
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update

Abstract Scenario: Wegvak ligt minder dan 2 meter in nieuwe gemeente
Achtergrond: Een wegvak valt na de BAG update gedeeltelijk in de nieuwe gemeente. Het wegvak wordt niet meegenomen in de BAG update. Deel van het wegvak ligt in de oude gemeente, wegvak blijft onder oude gemeente vallen

Gegeven een gebruiker de grens van de gemeente '<oude gemeente>' heeft aangepast waardoor minder dan twee meter van het wegvak met id <wegvak id> in de gemeente '<nieuwe gemeente>' komt te liggen
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update
En is er een melding betreffende '<melding onderwerp>' weggeschreven in de meldingen tabel

Voorbeelden:

| oude gemeente | wegvak id | nieuwe gemeente | melding onderwerp                                             |
| Kopenhagen    | 999999992 | Tirana          | de lengte van het wegvak dat in de nieuwe gemeente ligt       |
| Kopenhagen    | 999999990 | Tirana          | de lengte van het wegvak dat uit de eigen gemeente mag steken |
| Kopenhagen    | 999999989 | Tirana          | de lengte van het wegvak dat uit de eigen gemeente mag steken |

Scenario:  Wegvak ligt meer dan 2 meter in nieuwe gemeente
Achtergrond: Een wegvak valt na de BAG update voor meer dan 2 meter in een nieuwe gemeente, minder dan 2 meter in de oude gemeente

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999991 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Academiestraat_B' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
En 'Nicosia' is de wegbeheerder
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database

Abstract Scenario: De wegbeheerdersoort staat onjuist in de wegvakken tabel
Achtergrond: wegbeheersoort in nww_wegvakefemeriden en nww_wegbeheerders verschilt voor het wegbeheerderId

Gegeven een gebruiker de grens van de gemeente '<oude gemeente>' heeft aangepast waardoor het wegvak met id <wegvak id> onder gemeente '<nieuwe gemeente>' komt te vallen
En '<wegbeheerder>' is de wegbeheerder
En de wegbeheerdersoort staat onjuist in de wegvakken tabel
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update
En is er een melding betreffende '<melding onderwerp>' weggeschreven in de meldingen tabel

Voorbeelden:
| oude gemeente | wegvak id | nieuwe gemeente | wegbeheerder | melding onderwerp |
| Kopenhagen    | 999999987 | Tirana          | Berlijn      | de wegbeheerder   |
| Kopenhagen    | 999999986 | Tirana          | Tallinn      | de wegbeheerder   |

Abstract Scenario: Straat in nieuwe gemeente onbekend, oude straat ook onbekend
Achtergrond: Een wegvak valt na de BAG update onder een nieuwe gemeente, de oude straat is nog niet bekend in BAG, de nieuwe straat is niet gevonden

Gegeven een gebruiker de grens van de gemeente '<oude gemeente>' heeft aangepast waardoor het wegvak met id <wegvak id> onder gemeente '<nieuwe gemeente>' komt te vallen
En het wegvak verschuift door de aanpassing van de straat '<oude straat>' in '<oude gemeente>' naar '<nieuwe straat>' in '<nieuwe gemeente>'
En de straat '<oude straat>' is nog niet bekend in BAG
En de nieuwe straat is niet gevonden
En '<wegbeheerder>' is de wegbeheerder
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database
En is de straat '<oude straat>' toegevoegd als vervallen straat in de NWW database

Voorbeelden:

| oude gemeente | wegvak id | nieuwe gemeente | oude straat              | nieuwe straat    | wegbeheerder |
| Kopenhagen    | 999999985 | Tirana          | Achiel Van Ackerplein    | Academiestraat_N | de gemeente  |
| Kopenhagen    | 999999982 | Tirana          | Annuntiatenstraat        | Academiestraat_N | de gemeente  |
| Kopenhagen    | 999999979 | Tirana          | Albrecht Rodenbachstraat | Academiestraat_N | de gemeente  |

Abstract Scenario: Minder dan 2 meter wegvak ligt in nieuwe gemeente
Achtergrond: Minder dan 2 meter van een wegvak valt na de BAG update onder een nieuwe gemeente, de oude gemeente is nog niet bekend in BAG. Het wegvak wordt niet in BAG update meegenomen, straat wordt wel opgevoerd

Gegeven een gebruiker de grens van de gemeente '<oude gemeente>' heeft aangepast waardoor minder dan twee meter van het wegvak met id <wegvak id> in de gemeente '<nieuwe gemeente>' komt te liggen
En de straat '<straat>' is nog niet bekend in BAG
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update
En is er een melding betreffende '<melding>' weggeschreven in de meldingen tabel
En is de straat 'Ankerplein' toegevoegd als vervallen straat in de NWW database

Voorbeelden:

| oude gemeente | wegvak id | nieuwe gemeente | straat            | melding                                                 |
| Kopenhagen    | 999999984 | Tirana          | Ankerplein        | de lengte van het wegvak dat in de nieuwe gemeente ligt |
| Kopenhagen    | 999999983 | Tirana          | Annuntiatenstraat | de lengte van het wegvak dat in de nieuwe gemeente ligt |
| Kopenhagen    | 999999981 | Tirana          | Arsenaalstraat    | de lengte van het wegvak dat in de nieuwe gemeente ligt |
| Kopenhagen    | 999999980 | Tirana          | Arsenaalstraat    | de lengte van het wegvak dat in de nieuwe gemeente ligt |

Scenario: Straat in nieuwe gemeente onbekend
Achtergrond: Een wegvak valt na de BAG update onder een nieuwe gemeente, de nieuwe straat is niet gevonden en oude straatnaam is 'P', wegvak wordt niet meegenomen in de BAG update

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999978 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Adriaan Willaertstraat' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update
En is er een melding betreffende 'de gemeente' weggeschreven in de meldingen tabel

Scenario: Verschil gemeente in straten tabel & wegvakefemeriden tabel
Achtergrond: De gemeente in de straten tabel en de wegvakefemeriden tabel komt niet overeen. Wegvak wordt niet meegenomen in de BAG update.

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999977 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Academiestraat_B' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
En de gemeente staat verkeerd in de wegvakken tabel
Als de Bag Update is afgerond
Dan is het wegvak niet meegenomen in de BAG Update
En is er een melding betreffende 'de gemeente' weggeschreven in de meldingen tabel

Scenario: Hectopunten
#Achtergrond: Een wegvak met hectopunten valt na de BAG update onder een nieuwe gemeente, de hectopunten worden ook geupdatet

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999976 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Academiestraat_N' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
En 'de gemeente' is de wegbeheerder
En het wegvak heeft 4 hectopunten
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En zijn de hectopunten meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database
En zijn de hectopunten geupdatet in de NWW database

Scenario: Hectointervallen
#Achtergrond: Een wegvak met hectointervallen valt na de BAG update onder een nieuwe gemeente, de hectointervallen worden ook geupdatet

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999975 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Academiestraat_N' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
En 'de gemeente' is de wegbeheerder
En het wegvak heeft 1 hectointerval
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En zijn de hectointervallen meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database
En zijn de hectointervallen geupdatet in de NWW database

Scenario: Wegvak in route
#Een wegvak in een route valt na de BAG update onder een nieuwe gemeente, de route wordt ook geupdatet

Gegeven een gebruiker de grens van de gemeente 'Kopenhagen' heeft aangepast waardoor het wegvak met id 999999974 onder gemeente 'Tirana' komt te vallen
En het wegvak verschuift door de aanpassing van de straat 'Academiestraat_N' in 'Kopenhagen' naar 'Academiestraat_N' in 'Tirana'
En 'de gemeente' is de wegbeheerder
En het wegvak is onderdeel van 2 routes
Als de Bag Update is afgerond
Dan is het wegvak meegenomen in de BAG update
En zijn de routes meegenomen in de BAG update
En is het wegvak geupdatet in de NWW database
En zijn de routes geupdatet in de NWW database



