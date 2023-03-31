#region Exos Méthodes

#region Exo 1.1 Celsius , Farhenheit

//1.Dans les structures Celsius et Fahrenheit, écrire la fonction de conversion de l’une vers l’autre.

using Exo31032023;

Console.WriteLine("-------------- Celcius ----------------");
Celcius c = new Celcius();
c.Temperature = 20;

Console.WriteLine(" température en Celcius ");
Console.WriteLine(c.Temperature);

Console.WriteLine("la même après conversion en Farhenheit");
Farhenheit f = c.Convert();
Console.WriteLine(f.Temperature);

Console.WriteLine("fais chaud !!! ");


Console.WriteLine("------------ Fahrenheit ----------------");
Farhenheit f2 = new Farhenheit();
f2.Temperature = 68;

Console.WriteLine("température en Farhenheit ");
Console.WriteLine(f2.Temperature);


Console.WriteLine("la même après conversion en Celcius");
Celcius c2 = f.Convert();
Console.WriteLine(c.Temperature);

Console.WriteLine("fais froid !!!");

Console.ReadLine();

#endregion

#region Exo 1.2 , Equation second degré

//2.Ecrire une structure pour résoudre une équation du second degré.
//La structure devra contenir : 
//Trois variables membres publiques A, B et C de type double.
//Une méthode publique « Resoudre » retournant une valeur de type « bool » stipulant si une réponse a été trouvée et devra retourner également les
//valeurs de X1 et de X2 de type double.
//Si aucune solution n’a été trouvée, les valeurs de X1 et de X2 doivent être égale à « null ».















#endregion
#endregion


