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

CosmosObject Com1 = new Cometa(1, p1Com1, v1, 2000, mater, "COMET_707");

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

Point3D p1Planet1 = new Point3D(18, 201, 65);
Point3D p2Planet1 = new Point3D(18, 250, 65);

Vector v2 = new Vector(p1Planet1, p2Planet1);
Materials FePl = new Ferum(22);
Materials WPl = new Water(37);
Materials SPl = new Stown(41);

Materials[] materPl = { FePl, WPl, SPl };

Core core1 = new Core(800, 11000);

CosmosObject pl1 = new Planet(305, p1Planet1, v2, 1300, materPl, "Planet_Omega", core1);








