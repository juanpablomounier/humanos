using System;

namespace CodeandoConElCabe
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Un objeto y una persona se crearán, y el objeto caerá sobre la persona");

            var unHumano = new Persona("Roberto");
            
            Persona.Vive(unHumano); // true
            

            string Masa = Console.ReadLine();
            string Volumen = Console.ReadLine();

            float masa = float.Parse(Masa);
            float volumen = float.Parse(Volumen);

            var bola = new Cosa(masa, volumen);

            var fuerza = bola.Caer();

            if (fuerza > 200)
            {
                unHumano.Morir();
                bool vive = Persona.Vive(unHumano); // false
                Console.WriteLine(vive);
            }

            else
            {
                bool vive = Persona.Vive(unHumano); // false
                Console.WriteLine(vive);
            }
            
           

           

          

            
        }
    }

    public class Persona
    {
        public Persona(string nombre)
        {
            Nombre = nombre;
            EstaVivo = true;
        }

        private string Nombre { get; }
        private bool EstaVivo { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola soy {Nombre}");
        }

        public void Morir()
        {
            EstaVivo = false;
        }

        public static bool Vive(Persona unaPersona)
        {
            return unaPersona.EstaVivo;
        }
    }

    public class Cosa
    {

        public Cosa(float masa, float volumen)
        {
            Masa = masa;
            Volumen = volumen;

        }

        private float Masa { get;}
        private float Volumen { get;}
        

        public float Caer()
        {
            float fuerza = Masa * 10;
            return fuerza; 
        }

    }

}