using Building;

BuildingObject ecf = new BuildingObject(57);

Console.WriteLine("The maximum number of floors you can build is " + ecf.GetFloorCount(57));

Console.WriteLine("The maximum heigth you can buid is " + ecf.GetFloorMaxSize(57));
