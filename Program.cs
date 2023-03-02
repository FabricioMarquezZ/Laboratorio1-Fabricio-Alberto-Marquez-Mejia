using Laboratorio1_Fabricio_Alberto_Marquez_Mejia.Controllers;
using Laboratorio1_Fabricio_Alberto_Marquez_Mejia.Models;

persona persona= new persona(); 
Clspersona clspersona=new Clspersona();

persona.nombre = "Fabricio";
persona.edad = 23;
persona.sexo = "M";
persona.peso = 49;
persona.altura = 1.75;

clspersona.CalcularIMC(persona);    