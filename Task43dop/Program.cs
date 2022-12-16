Console.Clear();

Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Введите координату y1: ");
   double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Введите координату y2: ");
   double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Введите координату y3: ");
   double y3 = Convert.ToDouble(Console.ReadLine());

// double a = Math.Sqrt((x1-x2)*(x1-x2) + (y1 -y2)*(y1 -y2));
// double b = Math.Sqrt((x2-x3)*(x2-x3) + (y2 -y3)*(y2 -y3));
// double c = Math.Sqrt((x1-x3)*(x1-x3) + (y1 -y3)*(y1 -y3));

   double a = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1 -y2,2));
   double b = Math.Sqrt(Math.Pow(x2-x3,2) + Math.Pow(y2 -y3,2));
   double c = Math.Sqrt(Math.Pow(x1-x3,2) + Math.Pow(y1 -y3,2));

   double p = (a+b+c)/2;

   double S = Math.Round((Math.Sqrt(p*(p-a)*(p-b)*(p-c))),2);

   Console.WriteLine($"Площадь треугольника S = {S} см²");
//2 1 2 4 6 1

