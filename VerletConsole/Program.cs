/*
 * Adapted from https://www.algorithm-archive.org/contents/verlet_integration/verlet_integration.html
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerletClasses;
using VerletFunctions;

namespace VerletConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup();
            //setup variables
            Vector2D gravity = new Vector2D(0.0f, -9.81f);
            Vector2D position = new Vector2D(0.0f, 10.0f);
            Vector2D velocity = new Vector2D(5.0f, 0.0f);
            Vector2D originalPosition = position;
            Vector2D originalVelocity = velocity;
            float deltaTime = 0.01f;
            float dampFactor = 0.1f;
            //begin calculations &display
            float time = Functions.Verlet(ref position, gravity, ref velocity, deltaTime);
            Console.WriteLine("************* Verlet Integration ***********");
            Console.WriteLine("                       Original position is: {0}", originalPosition);
            Console.WriteLine("             Time for Verlet integration is: {0}", time);
            Console.WriteLine("                          Final position is: {0}\n", position);

            position = originalPosition;
            time = Functions.VerletDamped(ref position, gravity, ref velocity, deltaTime, dampFactor);
            Console.WriteLine("****** Damped Verlet Integration ***********");
            Console.WriteLine("                       Original position is: {0}", originalPosition);
            Console.WriteLine("             Time for Verlet integration is: {0}", time);
            Console.WriteLine("                          Final position is: {0}\n", position);

            position = originalPosition;
            time = Functions.StormerVerlet(ref position, gravity, ref velocity, deltaTime);
            Console.WriteLine("******* Stormer Verlet Integration *********");
            Console.WriteLine("                       Original position is: {0}", originalPosition);
            Console.WriteLine("     Time for Stormer Verlet integration is: {0}", time);
            Console.WriteLine(" Velocity for Stormer Verlet integration is: {0}", velocity);
            Console.WriteLine("                          Final position is: {0}\n", position);

            position = originalPosition;
            velocity = originalVelocity;
            time = Functions.VelocityVerlet(ref position, gravity, ref velocity, deltaTime);
            Console.WriteLine("******* Velocity Verlet Integration ********");
            Console.WriteLine("                       Original position is: {0}", originalPosition);
            Console.WriteLine("    Time for Velocity Verlet integration is: {0}", time);
            Console.WriteLine("Velocity for Velocity Verlet integration is: {0}", velocity);
            Console.WriteLine("                          Final position is: {0}\n", position);

            Console.WriteLine("+++++++++++++ Projectile Demo ++++++++++++++");
            originalPosition = new Vector2D();
            position = originalPosition;
            originalVelocity = new Vector2D(3.0f, 4.0f);
            velocity = originalVelocity;
            time = Functions.VelocityVerlet(ref position, gravity, ref velocity, deltaTime);
            Console.WriteLine("------- Velocity Verlet Integration --------");
            Console.WriteLine("                       Original position is: {0}", originalPosition);
            Console.WriteLine("    Time for Velocity Verlet integration is: {0}", time);
            Console.WriteLine("Velocity for Velocity Verlet integration is: {0}", velocity);
            Console.WriteLine("                          Final position is: {0}\n", position);

            Console.ReadLine();
        }//eom

        static void Setup()
        {
            Console.Title = "Verlet Integration Console Demo";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }//eom
    }//eoc
}//eon
