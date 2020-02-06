using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad:10);
            ImpimirCursosEscuela(engine.Escuela);

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de Polimorfismo");

            var alumnoTest = new Alumno { Nombre = "Luis Enrique" };
            ObjetoEscuelaBase ob = alumnoTest;

            Printer.WriteTitle("Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"UniqueId: {alumnoTest.UniqueId}");
            WriteLine($"GetType: {alumnoTest.GetType()}");

            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"UniqueId: {ob.UniqueId}");
            WriteLine($"GetType: {ob.GetType()}");

            var obtDummy = new ObjetoEscuelaBase() {Nombre="Juan" };
            
            Printer.WriteTitle("obtDummy");
            WriteLine($"Alumno: {obtDummy.Nombre}");
            WriteLine($"UniqueId: {obtDummy.UniqueId}");
            WriteLine($"GetType: {obtDummy.GetType()}");
            

            ReadLine();
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            
            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
