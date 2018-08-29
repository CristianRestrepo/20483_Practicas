using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20483_Archivos
{
    class Archivos
    {
        private string ruta;
        private string archivo;


        public Archivos(string pArchivo)
        {
            archivo = pArchivo;
            ruta = Directory.GetCurrentDirectory()  + @"\" + archivo.ToString();
        }

        public string Archivo {
             get { return archivo; }
        }
        public string Ruta
        {
            get { return ruta; }
        }

        public void EscribirArchivoStream() {
            StreamWriter sw = new StreamWriter(ruta);
            sw.Write("Palabra de prueba");
            sw.Close();
        }

        public void LeerArchivoStream() {
            StreamReader sr = new StreamReader(ruta);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        public void EscribirArchivoFileStream()
        {
            //Se crea el FileStream
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write, FileShare.None);

            //Se crea el writer
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("prueba 2");
            sw.Close();
        }

        public void LeerArchivoFileStream()
        {
            //Se crea el FileStream
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamReader sr = new StreamReader(ruta);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

        }
    }

}
