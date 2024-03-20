# Történelem Quiz
## Kérdés típusok
* Egyszeres válasz
* Többszörös válasz
* Igaz Hamis
* Évszám
* Térképes (maybe)
* Sorrendbe rendezés (maybe)

## Osztály minta
Mindegyiknek kérdés típusnak külön osztály, egy absztrakt osztályból származtatva
~~~
class Kérdés {
    var cím;
}
~~~

### Egyszeres választós
~~~
class EgyszeresKérdés : Kérdés {
    var válaszok[4];
}
~~~

### Többszörös választós
~~~
class TöbbszörösKérdés : Kérdés {
    var válaszok[4]
}
~~~

### Igaz/Hamis
~~~
class IgazHamisKérdés : Kérdés {
    var igaz;
}
~~~

### Évszám
~~~
class ÉvszámKérdés : Kérdés {
    var helyes;
}
~~~

### Válasz osztály
~~~
class Válasz {
    var szöveg;
    var helyes;
}
~~~

## JSON minta
### Egyszeres választós
~~~
{
    "tipus": "egyszeres",
    "cím": "Ki volt közülük magyar király?",
    "válaszok": [
        {
            "szöveg": "Hunyadi László",
            "helyes": false
        },{
            "szöveg": "Hunyadi Mátyás",
            "helyes": true
        },{
            "szöveg": "Hunyadi János",
            "helyes": false
        },{
            "szöveg": "Hunyadi István",
            "helyes": false
        }
    ]
}
~~~
### Többszörös választós
~~~
{
    "típus": "többszörös",
    "cím": "Melyik országok vettek részt az 1. Világháborúban?",
    "válaszok": [
        {
            "szöveg": "Nagy Britannia",
            "helyes": true
        },{
            "szöveg": "Oroszország",
            "helyes": true
        }, {
            "szöveg": "Spanyolország",
            "helyes": false
        }, {
            "szöveg": "Norvégia",
            "helyes": false
        }
    ]
}
~~~

### Igaz/Hamis
~~~
{
    "cím": "Lenin 1930-ban halt meg",
    "helyes": false
}
~~~

### Évszám
~~~
{
    "cím": "Mikor lett vége a 2. Világháborúnak",
    "helyes": 1945
}
~~~