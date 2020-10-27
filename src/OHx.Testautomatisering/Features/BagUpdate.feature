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