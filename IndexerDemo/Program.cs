using IndexerDemo;
using System.Collections;

ArrayList liste = new ArrayList() { 10, 22, 33 };
Gun gun = new Gun();

liste[0] = 11;
var ilkEleman = liste[0];

//gun[1] = "xyz";
string haftaninIlkGunu = gun[1];
Console.WriteLine(haftaninIlkGunu);