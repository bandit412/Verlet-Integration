using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerletClasses;

namespace VerletFunctions
{
    public static class Functions
    {
        //This method only works if there is NO positive Velocity.Y 
        //(i.e. the projectile must be launched horizontally or just released/dropped)
        public static float Verlet(ref Vector2D position, Vector2D acceleration, ref Vector2D velocity, float deltaTime)
        {
            Vector2D previousPosition = position;
            float time = 0.0f;
            while (position.Y > 0)
            {
                time += deltaTime;
                Vector2D tempPosition = position;
                position = position * 2 - previousPosition + acceleration * deltaTime * deltaTime;
                previousPosition = tempPosition;
            }//end while
            position.X += velocity.X * time;
            return time;
        }//eom

        public static float VerletDamped(ref Vector2D position, Vector2D acceleration, ref Vector2D velocity, float deltaTime, float dampFactor)
        {
            Vector2D previousPosition = position;
            float time = 0.0f;
            while (position.Y > 0)
            {
                time += deltaTime;
                Vector2D tempPosition = position;
                position += (position - previousPosition) * (1 - dampFactor) + acceleration * deltaTime * deltaTime;
                previousPosition = tempPosition;
            }//end while
            position.X += velocity.X * time;
            return time;
        }//eom

        //This method only works if there is NO positive Velocity.Y 
        //(i.e. the projectile must be launched horizontally or just released/dropped)
        public static float StormerVerlet(ref Vector2D position, Vector2D acceleration, ref Vector2D velocity, float deltaTime)
        {
            Vector2D previousPosition = position;
            float time = 0.0f;
            while (position.Y > 0)
            {
                time += deltaTime;
                Vector2D tempPosition = position;
                position = position * 2 - previousPosition + acceleration * deltaTime * deltaTime;
                previousPosition = tempPosition;
                // Because acceleration is constant, velocity is straightforward
                velocity += acceleration * deltaTime;
            }//end while
            position.X += velocity.X * time;
            return time;
        }//eom

        public static float VelocityVerlet(ref Vector2D position, Vector2D acceleration, ref Vector2D velocity, float deltaTime)
        {
            Vector2D previousPosition = position;
            float time = 0.0f;
            while (position.Y >= 0)
            {
                time += deltaTime;
                position += velocity * deltaTime + acceleration * 0.5f * deltaTime * deltaTime;
                velocity += acceleration * deltaTime;
            }//end while
            return time;
        }//eom

        //This method only works if there is NO positive Velocity.Y 
        //(i.e. the projectile must be launched horizontally or just released/dropped)
        public static List<Vector2D> StormerVerletList(Vector2D position, Vector2D acceleration, Vector2D velocity, float deltaTime)
        {
            List<Vector2D> points = new List<Vector2D>();
            Vector2D previousPosition = position;
            float time = 0.0f;
            while (position.Y >= 0)
            {
                time += deltaTime;
                Vector2D tempPosition = position;
                position = position * 2 - previousPosition + acceleration * deltaTime * deltaTime;
                previousPosition = tempPosition;
                // Because acceleration is constant, velocity is straightforward
                velocity += acceleration * deltaTime;
                position.X = velocity.X * time;
                points.Add(position);
            }//end while
            
            return points;
        }//eom

        public static List<Vector2D> VelocityVerletList(Vector2D position, Vector2D acceleration, Vector2D velocity, float deltaTime)
        {
            List<Vector2D> points = new List<Vector2D>();
            float time = 0.0f;
            while (position.Y >= 0)
            {
                time += deltaTime;
                position += velocity * deltaTime + acceleration * 0.5f * deltaTime * deltaTime;
                points.Add(position);
                velocity += acceleration * deltaTime;
            }//end while
            return points;
        }//eom

        public static bool IsFloat(string input)
        {
            float f;
            return float.TryParse(input, out f);
        }//eom
    }//eoc
}//eon
