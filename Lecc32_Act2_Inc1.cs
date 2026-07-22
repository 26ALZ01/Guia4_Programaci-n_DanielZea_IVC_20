using System;

namespace SignoZodiacal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Descubre tu Signo Zodiacal y Horóscopo ===");

            
            Console.Write("Ingresa tu mes de nacimiento (1-12): ");
            int mes = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Ingresa tu día de nacimiento (1-31): ");
            int dia = Convert.ToInt32(Console.ReadLine());

            string signo = "";
            string horoscopo = "";

            
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            {
                signo = "Aries";
                horoscopo = "Hoy es un día excelente para tomar la iniciativa. Tu energía es imparable y lograrás lo que te propongas.";
            }
            else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            {
                signo = "Tauro";
                horoscopo = "La paciencia será tu mejor aliada hoy. Disfruta de las pequeñas cosas y las recompensas llegarán solas.";
            }
            else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                signo = "Géminis";
                horoscopo = "Tu curiosidad te llevará a descubrir algo fascinante. Mantén tu mente abierta y comunícate con claridad.";
            }
            else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            {
                signo = "Cáncer";
                horoscopo = "Es un buen momento para conectar con tus emociones. Recibirás una noticia reconfortante de alguien cercano.";
            }
            else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            {
                signo = "Leo";
                horoscopo = "Tu creatividad está en su punto máximo. No temas brillar y compartir tus ideas con el mundo hoy.";
            }
            else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
                signo = "Virgo";
                horoscopo = "La organización te traerá paz mental hoy. Enfócate en los detalles y resolverás cualquier problema con facilidad.";
            }
            else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
                signo = "Libra";
                horoscopo = "Busca el equilibrio en tus tareas diarias. Una conversación honesta te abrirá nuevas puertas inesperadas.";
            }
            else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
                signo = "Escorpio";
                horoscopo = "Confía en tu intuición, te guiará hacia la decisión correcta. Tu intensidad hoy será tu mayor fortaleza.";
            }
            else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                signo = "Sagitario";
                horoscopo = "La aventura llama a tu puerta. Atrévete a salir de tu zona de confort y aprenderás algo valioso.";
            }
            else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            {
                signo = "Capricornio";
                horoscopo = "Tu disciplina está dando frutos. Sigue trabajando duro, pero no olvides tomarte un merecido descanso.";
            }
            else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            {
                signo = "Acuario";
                horoscopo = "Tus ideas innovadoras sorprenderán a alguien importante. Sé auténtico y no temas pensar diferente.";
            }
            else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            {
                signo = "Piscis";
                horoscopo = "Tu empatía será un gran apoyo para alguien que te necesita hoy. Déjate guiar por tu gran sensibilidad.";
            }
            else
            {
                Console.WriteLine("\nLa fecha ingresada no es válida. Revisa los datos.");
                Console.ReadLine();
                return; 
            }

            
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"Tu signo zodiacal es: {signo}");
            Console.WriteLine($"Tu horóscopo: {horoscopo}");
            Console.WriteLine("------------------------------------------------");

            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
