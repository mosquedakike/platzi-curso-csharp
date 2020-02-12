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

            WriteLine("\n[ob = alumnoTest]\n");

            Printer.WriteTitle("Objeto-padre [alumnoTest]");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"UniqueId: {alumnoTest.UniqueId}");
            WriteLine($"GetType: {alumnoTest.GetType()}");
            WriteLine($"Evaluaciones: {alumnoTest.Evaluaciones}");


            Printer.WriteTitle("Objeto-hijo [ob]");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"UniqueId: {ob.UniqueId}");
            WriteLine($"GetType: {ob.GetType()}");
            WriteLine($"Evaluaciones: Este objeto no puede acceder a esta propiedad");

            var obtDummy = new ObjetoEscuelaBase() { Nombre = "Juanca" };

            Printer.WriteTitle("Objeto-ObjetoEscuelaBase [obtDummy]");
            WriteLine($"Alumno: {obtDummy.Nombre}");
            WriteLine($"UniqueId: {obtDummy.UniqueId}");
            WriteLine($"GetType: {obtDummy.GetType()}");

            //alumnoTest = (Alumno)obtDummy;
            var evaluacion = new Evaluacion()
            {
               Nombre = "Parcial #1",
               Nota = 4.5f
            };

            WriteLine($"Nombre: {evaluacion.Nombre}, Nota: {evaluacion.Nota}");

            ob = evaluacion;

            if (ob is Alumno)
            {
                Alumno AlumnoRecuperado = (Alumno)ob;
                WriteLine(AlumnoRecuperado);
            }

            Alumno AlumnoRecuperado2 = ob as Alumno;
            if (AlumnoRecuperado2 != null)
            {
                WriteLine("Excelente");
            }

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
