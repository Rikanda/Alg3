using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Alg3
{
   
    class Program
    {
       


       static void Main(string[] args)
        {
           
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
// результат выполнения

//| Method | Mean | Error | StdDev |
//| ------------------------------ | ---------:| ----------:| ----------:|
//    | TestPointDistanceFloatClass | 1.811 ns | 0.0294 ns | 0.0261 ns |
//  | TestPointDistanceDoubleClass | 2.141 ns | 0.0214 ns | 0.0200 ns |
// | TestPointDistanceFloatStruct | 1.903 ns | 0.0191 ns | 0.0169 ns |
//| TestPointDistanceDoubleStruct | 2.355 ns | 0.0612 ns | 0.0573 ns |


    }
    }
    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }

    public class BenchmarkClass
    {

        //public static int[] numb ()
        //{
        //   int[] numbers = new int[3];
        //    Random rnd = new Random(10000);
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = rnd.Next();
        //    }
        //    return numbers;
        //}
// не смогла придумать, как передавать значения элементов массива в качестве координат X и Y для точки
      
        public PointClass aPoint  = new PointClass { X = 1, Y = 2 };
        public PointClass bPoint = new PointClass { X = 5, Y = 15 };
        public PointStruct a = new PointStruct { X = 1, Y = 2 };
        public PointStruct b = new PointStruct { X = 5, Y = 15 };
        public static float PointDistanceFloatClass(PointClass pointOne, PointClass pointTwo)
        {
       
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceDoubleClass(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceFloatStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceDoubleStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        
        [Benchmark]
        public void TestPointDistanceFloatClass()
        {
            
            PointDistanceFloatClass(aPoint, bPoint);
        }

        [Benchmark]
        public void TestPointDistanceDoubleClass()
        {
            
            PointDistanceDoubleClass(aPoint, bPoint);
        }

        [Benchmark]
        public void TestPointDistanceFloatStruct()
        {

            PointDistanceFloatStruct(a, b);
        }

        [Benchmark]
        public void TestPointDistanceDoubleStruct()
        {

            PointDistanceDoubleStruct(a, b);
        }
    }
}
