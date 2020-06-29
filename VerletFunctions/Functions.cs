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
        }

        public static bool IsFloat(string input)
        {
            float f;
            return float.TryParse(input, out f);
        }//eom
    }//eoc
}//eon
