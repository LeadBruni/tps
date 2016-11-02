using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace TP4
{
    class Test
    {
        public static void Main()
        {
            string ruta;

            try


            {
                Console.WriteLine("ingrese la ruta del archivo");

                ruta = Console.ReadLine();
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(ruta))// el using automaticamente cierra el archivo que se esta leyendo
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (System.IO.PathTooLongException)
            {
                // Let the user know what went wrong.
                Console.WriteLine("la ruta ingresada es muy larga!");
            }


            //ahora vamos a catchear excepciones del System.IO(IO.ExceptionClass)


            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("el archivo no fue encontrado");
            }

            catch (System.ArgumentException)
            {
                Console.WriteLine("no ingresaste una ruta valida");
            }



        }
        }
    }