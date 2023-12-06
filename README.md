# WPFStampante
un programma in wpf app che emula una stampante e le sue funzioni principali usando <br>
due classi di nome "stampante" e "pagina" il tutto ricoperto da una interfaccia grafica <br>
sviluppata in XAML

# il programma usa due classi principali
ecco una piccola descrizione con i costruttutori
## Stampante
qui sotto gli attributi e il costruttore base leggermente modificato
~~~C#
public enum colore
{
    C,
    M,
    Y,
    B
}

private int ciano;
private int magenta;
private int yellow;
private int black;
private int carta = 200;

public int Ciano { get; set; }
public int Magenta { get; set; }
public int Yellow { get; set; }
public int Black { get; set; }
public int Carta { get; set; }

public Stampante()
{
    Ciano = Magenta = Yellow = Black = 100;
    Carta = 0;
}
~~~
qui sotto i metodi che emulano le funzioni della stampante (da finire probabilmente)
~~~C#
public bool stampa(Pagina page)
{
    if (Carta >= 1 && Ciano >= page.CostoC && Magenta >= page.CostoM && Yellow >= page.CostoY && Black >= page.CostoB)
    {
        Ciano -= page.CostoC;
        Magenta -= page.CostoM;
        Yellow -= page.CostoY;
        Black -= page.CostoB;
        Carta--;

        return true;
    }
   
    return false;
}

public int StatoCarta()
{
    return Carta;
}
public void aggiungiCarta(int nCarta)
{
    if  (Carta + nCarta < 200)
    {
        Carta += nCarta;
    }
}


public int StatoInchiostro(colore c)
{
    return 1;
}

public void SostituisciColore(colore c)
{

}   
~~~
## Pagina

qui sotto gli attributi
~~~C#
private int _ciano;
private int _magenta;
private int _yellow;
private int _black;

public int CostoC { get => _ciano; set => _ciano = value; }
public int CostoM { get => _magenta; set => _magenta = value; }
public int CostoY { get => _yellow; set => _yellow = value; }
public int CostoB { get => _black; set => _black = value; }
~~~
qui sotto i costruttori aggiunti
~~~C#
 public Pagina(int coloreM, int coloreB, int coloreY, int coloreC)
 {
     if (!(coloreM > 3 && coloreB > 3 && coloreC > 3 && coloreY > 3))
     {
         CostoC = coloreC;
         CostoB = coloreB;
         CostoY = coloreY;
         CostoM = coloreM;
     }
     else
     {
         throw new Exception();
     }
 }

 public Pagina()
 {
     Random rnd = new Random();
     CostoB = rnd.Next(0, 5);
     CostoY = rnd.Next(0, 5);
     CostoM = rnd.Next(0, 5);
     CostoC = rnd.Next(0, 5);
 }
~~~
