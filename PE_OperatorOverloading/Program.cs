using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 v1 = new Vector2(10, 10);
            Vector2 v2 = new Vector2(2, 4);
            Vector3 v3 = new Vector3(1.5, 2, 3.14159);
            Vector3 v4 = new Vector3(5, 5, 5);

            Console.WriteLine("Operator Overloading Test Run");

            Console.WriteLine("--- Initial Vectors ---");
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            Console.WriteLine("--- After Changes ---");
            Console.WriteLine("Adding " + v1 + " and (4, -13): " + 
                                                (v1 += new Vector2(4, -13)   ));
            Console.WriteLine("Multiplying " + v2 + " by 2: " + 
                                                (v2 *= 2)    );
            Console.WriteLine("Subtracting (1, 2, 3) from " + v3 + ": " + 
                                                (v3-=new Vector3(1, 2, 3)  ));
            Console.WriteLine("Dividing " + v4 + " by 2.5: " + 
                                                (v4 /= 2.5)   );

            Console.WriteLine("--- After Explicit Cast ---");
            List<Vector3> vects = new List<Vector3>();
            vects.Add(v1); vects.Add(v2); vects.Add(v3); vects.Add(v4);
            Vector2 tempVector = (Vector2)vects[3];
            Console.WriteLine("Element at index 3: "+tempVector);

            Console.WriteLine("--- Average ---");
            Vector3 average = new Vector3();
            for (int a = 0; a < vects.Count; a++)
            {
                average += vects[a];
            }
            average = average / 4;
            Console.WriteLine(average);

            Console.ReadLine();
        }
    }
}
