// See https://aka.ms/new-console-template for more information

using Access1.Models;


//Model publicdir. Hem constructorun hemde methodun icinde ,cagirmaq olur.
//ram privatedir.
//memorage protected dir.
Computer comp = new Computer();
comp.Model = "Honor";
comp.Memorage = 256; //error  verir ,cunki protected instance de el catan deil
comp._ram = 8; //error verir cunki private di

//encapsulation
comp.Ram = 16;
Console.WriteLine(comp.Ram);

//readonly fields
comp.Color = "black";  // error verir cunki set elemk olmaz


