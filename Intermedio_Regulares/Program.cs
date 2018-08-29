using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Intermedio_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expresion Basica
            string texto = "La casa del casamentero";
            string exp = "casa";
           
            matchExp(texto, exp);
            
            //uso de . significa cualquier caracter 
            //despues de mi expresion
            exp = " d.";
            matchExp(texto, exp);

            //Clases de caracteres, la expresion 
            //busca alguno de los caracteres definidos en mi colección
            texto = "Hola Necio";
            exp = "N[ie]c";
            matchExp(texto, exp);

            //Rango, se pueden definir rangos de letras
            exp = "N[a-u]c";
            matchExp(texto, exp);

            //Complemento, indica todo aquello que no hace parte de un grupo definido
            //^ es una negación
            texto = "Hola Nacio";
            exp = "N[^ie]c";
            matchExp(texto, exp);

            //Se busca expresión desde posicion especifica
            texto = "youtube es una mierda";
            exp = "m[ia]";

            Regex expReg = new Regex(exp);
            if (expReg.IsMatch(texto, 13))
                Console.WriteLine("Si tiene");
            else
                Console.WriteLine("No tiene");
            Console.WriteLine("\n--------------");
            
            //para validar si finaliza
            exp = "erda$";
            matchExp(texto, exp);

            //Cuantificador, valida que una expresion exista n cantidad de veces
            exp = "[0-9]{2}";
            texto = "25 años";
            matchExp(texto, exp);


            //alternacion
            texto = "yo programo en c";
            exp = "c|java|python";

            //split, sirve para devidir nuestra cadena
            //tomando como punto de corte nuestra expresion
            texto = "este es un test de sep, division";
            exp = ",";

            string[] cadenas = Regex.Split(texto, exp);
            foreach (string c in cadenas) 
                Console.WriteLine(c);

            //Reemplaza
            texto = "yo hablo ingles";
            expReg = new Regex("ingles");
            string reemplazo = "español";

            string resultado = expReg.Replace(texto, reemplazo);
            Console.WriteLine(resultado);
            Console.ReadLine();

        }


        public static void matchExp(string pTexto, string pExp)
        {
            //Definimos el matchCollection para realizar la busqueda de la expresion
            //Regex.MatchCollection(texto, expresion regular)

            MatchCollection match = Regex.Matches(pTexto, pExp);
            foreach (Match e in match)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\n-----------------");
        }
    }
}
