Console.Clear();

Console.Write("Введите координату X1: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y1: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z1: ");
double z = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());



double result = Math.Sqrt((x-x2)*(x-x2) + (y-y2)*(y-y2) + (z-z2)*(z-z2));

result = Math.Round(result, 2);

Console.Write(result);

