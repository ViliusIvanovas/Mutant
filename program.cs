Mutant John = new Mutant("John");

Mutant Jane = new Mutant("Jane");

John.GetInfo();
Jane.GetInfo();

John.Greet(Jane);
Jane.Greet(John);

Park goofySpook = new Park("Goofy spook", 33);

goofySpook.Entrance(John);
goofySpook.Entrance(Jane);

Park elderlyHorror = new Park("Elderly Horror", 70);

elderlyHorror.Entrance(John);
elderlyHorror.Entrance(Jane);

Console.ReadKey();