using LESSON_14_12_23_COMETA;
using LESSON_14_12_23_COMETA.Mater;
using LESSON_14_12_23_COMETA.Object;
using LESSON_14_12_23_COMETA.Point;


//   Комета


Materials Fe = new Ferum(35);
Materials W = new Water(10);
Materials S = new Stown(55);

Materials[] mater = {Fe, W, S};

Point3D p1Com1 = new Point3D(4, 40, 10);
Point3D p2Com1 = new Point3D(4, 28, 10);

Vector v1 = new Vector(p1Com1, p2Com1);
Point3D vectorCom1 = v1.GetVector();

CosmosObject Com1 = new Cometa(355, p1Com1, v1, 2000, mater, "COMET_707");

Com1.PrintObject();
Console.WriteLine();

//  Запуск кометы

Console.WriteLine("Хотите посмотреть текущие координаты кометы? (если да - нажмите Enter)");
ConsoleKeyInfo keyInfo = Console.ReadKey(); 

if (keyInfo.Key == ConsoleKey.Enter)
{
    for (int i = 0; i < 50; i++)
    {
        if (vectorCom1.CoordX > 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordX++;
            Thread.Sleep(100);
            Console.Clear();
        }
        else if (vectorCom1.CoordX < 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordX--;
            Thread.Sleep(100);
            Console.Clear();
        }
        else if (vectorCom1.CoordY > 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordY++;
            Thread.Sleep(100);
            Console.Clear();
        }
        else if (vectorCom1.CoordY < 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordY--;
            Thread.Sleep(100);
            Console.Clear();
        }
        else if (vectorCom1.CoordZ > 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordZ++;
            Thread.Sleep(100);
            Console.Clear();
        }
        else if (vectorCom1.CoordZ < 0)
        {
            Console.WriteLine($" Комета летит по следующим координатам: X:{Com1.Point.CoordX}, Y:{Com1.Point.CoordY}, Z:{Com1.Point.CoordZ}");
            Com1.Point.CoordZ--;
            Thread.Sleep(100);
            Console.Clear();
        }
    }
}


// Планета
// Меркурий
Point3D p1Planet1 = new Point3D(18, 201, 65);
Point3D p2Planet1 = new Point3D(18, 250, 65);

Vector v2 = new Vector(p1Planet1, p2Planet1);
Materials FePl = new Ferum(62);
Materials WPl = new Water(17);
Materials SPl = new Stown(21);

Materials[] materPl = { FePl, WPl, SPl };

Core core1 = new Core(530, 3180);

CosmosObject pl1 = new Planet(305, p1Planet1, v2, 172332, materPl, "Mercury", core1);

pl1.PrintObject();
Console.WriteLine();

// Солнце
Point3D p1Planet2 = new Point3D(1, 2, 1);
Point3D p2Planet2 = new Point3D(1, 3, 1);

Vector v3 = new Vector(p1Planet2, p2Planet2);
Materials FeSun = new Ferum(92);
Materials WPSun = new Water(0);
Materials SSun = new Stown(8);

Materials[] materSun = { FeSun, WPSun, SSun };

Core core2 = new Core(15000000, 150000);

CosmosObject plSun = new Planet(1, p1Planet2, v3, 781200, materSun, "Sun", core2);

plSun.PrintObject();
Console.WriteLine();








