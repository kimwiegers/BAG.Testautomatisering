Functionaliteit: BagImport

Abstract Scenario: De gemeente Bunnik wordt samengevoegd met Zeist
Gegeven de gemeente 'Bunnik' na een gemeentelijke herindeling toegevoegd is aan de gemeente 'Zeist'
Als de BAG import is afgerond
Dan krijgen alle straten onder de gemeente 'Bunnik' in gga_straten de status 'vervallen' 
En worden de straten opgevoerd als horende bij gemeente 'Zeist' in gga_straten met de status 'BAG-straat'
En is in gga_woonplaatsen is een nieuw record aangemaakt voor '<woonplaats>' als horende bij gemeente 'Zeist'

Voorbeelden:

| woonplaats |
| Werkhoven  |
| Bunnik     |
| Odijk      |

Scenario: Een woonplaats valt na een gemeentelijke herindeling onder een andere gemeente
Gegeven de woonplaats 'Bocholtz' na een gemeentelijke herindeling is verschoven van de gemeente 'Simpelveld' naar de gemeente 'Heerlen'
Als de BAG import is afgerond
Dan krijgen alle straten in 'Bocholtz' onder de gemeente 'Simpelveld' in gga_straten de status 'vervallen'
En worden de straten in de woonplaats 'Bocholtz' opgevoerd als horende bij gemeente 'Heerlen' in gga_straten met de status 'BAG-straat'
En is in gga_woonplaatsen is een nieuw record aangemaakt voor 'Bocholtz' als horende bij gemeente 'Heerlen'

Abstract Scenario:  De naam van een gemeente is gewijzigd
Gegeven de gemeente '<oude gemeentenaam>' aangepast is naar '<nieuwe gemeentenaam>' 
Als de BAG import is afgerond
Dan is de naam in gga_gemeenten aangepast naar '<nieuwe gemeentenaam>'

Voorbeelden:

| oude gemeentenaam | nieuwe gemeentenaam |
| Schiedam          | Schildam            |
| Sudwest-Fryslan   | Súdwest-Fryslân     |

Scenario: De naam van een woonplaats is gewijzigd
Gegeven de woonplaats 'Kropswolde' is hernaamd naar 'Kipswolde'
Als de BAG import is afgerond
Dan En is de naam in gga_woonplaatsen aangepast naar 'Kipswolde'


#TODO: Kijken hoe dit in de praktijk werkt en test maken
Scenario:  Een straatnaam is gewijzigd
Gegeven de straat 'Zwet' is aangepast naar 'Zweet'
Als de BAG import is afgerond
Dan En is de naam in gga_straten aangepast naar 'Zweet'

Scenario:  Het BAG id van een bestaande 'P' straat (een straat bekend in BAG)  is gewijzigd
Gegeven het BAG id van 'Bieslaan' in 'Appingedam' gewijzigd is van '01234' naar '0003300000116991'
Als de BAG import is afgerond
Dan krijgt de de straat met BAG id '01234' het type 'vervallen'
En is er een nieuw record aangemaakt in gga_straten voor 'Bieslaan' met BAG id '0003300000116991'

Scenario: Het BAG id en de naam van een bestaande 'P' straat (een straat bekend in BAG)  is gewijzigd
Gegeven de naam  van een straat is gewijzigd van 'Bifoehof' naar 'Difoehof'
En het BAG id van 'Difoehof' in 'Capelle aan den IJssel' gewijzigd is van '12345' naar '0502300000001971'
Als de BAG import is afgerond
Dan krijgt de de straat met BAG id '12345' het type 'vervallen'
En is er een nieuw record aangemaakt in gga_straten voor 'Difoehof' met BAG id '0003300000116991'

Scenario: Er is een nieuwe BAG straat die nog niet bekend is in de BN
Gegeven de straat 'Karrebosserveldweg' in de gemeente 'Echt-Susteren' nog niet bekend is in de BN
Als de BAG import is afgerond
Dan is de straat 'Karrebosserveldweg' toegevoegd in gga_straten als 'BAG-straat'

Scenario: Er is een nieuwe BAG-straat die nu als 'A' straat in BN staat met andere data
Gegeven de straat 'Lampenist' in de woonplaats 'Amersfoort' in BN staat als 'RWS-straat'
En de naam-gerelateerde velden zijn leeg
En de straat is inmiddels bekend in BAG
Als de BAG import is afgerond
Dan is de straat 'Lampenist' geupdatet in gga_straten als 'BAG-straat'
En zijn de naam-gerelateerde velden van 'Lampenist' gevuld met de data die in BAG bekend is

Scenario: Er is een nieuwe BAG-straat die nu als 'V' straat in BN staat, waarvan de data verschilt
Gegeven de straat 'De Stator' in de woonplaats 'Amersfoort' in BN staat als 'vervallen'
En de straat is inmiddels bekend in BAG
En de naam_ptt en naam_afkorting van de straat 'De Stator' staan foutief in BN
Als de BAG import is afgerond
Dan is de straat 'De Stator' geupdatet in gga_straten als 'BAG-straat'
En zijn de naam-gerelateerde velden van 'De Stator' gevuld met de data die in BAG bekend is

Scenario: Er is een nieuwe BAG 'P' straat die nu als 'V' straat in BN staat met dezelfde data
Gegeven de straat 'Woudrichemstraat' in de woonplaats 'Amersfoort' in BN staat als 'vervallen' 
En de straat is inmiddels bekend in BAG
Als de BAG import is afgerond
Dan is de straat 'Woudrichemstraat' geupdatet in gga_straten als 'BAG-straat'

Scenario: Een BAG-straat is opgeheven en wordt omgezet naar 'Vervallen' straat
Gegeven de straat 'Marie Vierdaghof' in de woonplaats 'Amersfoort' in BN staat als 'BAG-straat' 
En de straat is inmiddels vervallen in BAG
Als de BAG import is afgerond
Dan is de straat 'Marie Vierdaghof' geupdatet in gga_straten als 'vervallen'

Scenario: Een BAG-straat is opgeheven en wordt omgezet naar 'vervallen' straat en de gegevens zijn gewijzigd
Gegeven de straat 'Ton van Heugtenhof' in de woonplaats 'Amersfoort' in BN staat als 'BAG-straat'
En de straat is inmiddels vervallen in BAG
En de naam_officieel van de straat 'Ton van Heugtenhof' mist in de BN
Als de BAG import is afgerond
Dan is de straat 'Ton van Heugtenhof' geupdatet in gga_straten als 'vervallen'
En zijn de naam-gerelateerde velden van 'Ton van Heugtenhof' gevuld met de data die in BAG bekend is


