using System;
namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            Hexagon hex2 = new Hexagon();
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
            {
                Console.WriteLine("Points: {0}", itfPt2.Points);
            }
            else
            {
                Console.WriteLine("OOPS! Not pointy...");
            }

            Console.WriteLine();

            Shape[] shapes = { new Hexagon("MyHex"), new Circle("MyCircle"), new Triangle("Joe"), new Circle("Jojo") };
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();

                if (shapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy)shapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0} \'s not pointy!", shapes[i].PetName);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("************************************************************************************");

            Shape[] myShapes = { new Hexagon("ScHex"), new Circle("ScCirc"), new Triangle("ScTrian"), new Circle("AnotherCirc") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                if (myShapes[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes[i]);
                }
            }

            Console.WriteLine("************************************************************************************");

            Shape[] my2Shapes = { new Hexagon(), new Circle(), new Triangle()};
            IPointy firstPointyItem = FindFirstPointyShape(my2Shapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                {
                    return s as IPointy;
                }                
            }
            return null;
        }
    }
}
