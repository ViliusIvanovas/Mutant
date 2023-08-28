public class Park
{
    public string Name;
    public int EntranceRequirement;

    public Park(string name, int requirement)
    {
        Name = name;
        EntranceRequirement = requirement;
    }

    public void Entrance(Mutant guest)
    {
        if (guest.GetAverageAge() < EntranceRequirement)
        {
            Console.WriteLine("Sorry " + guest.Name + ", your body parts have to have an average age of " + EntranceRequirement + ", you only have: " + guest.GetAverageAge() + " you won't be allowed in " + Name);
        }
        else
        {
            Console.WriteLine("You're free to enter " + Name + ", " + guest.Name + ", your average body parts age is: " + guest.GetAverageAge() + " and you only need " + EntranceRequirement + " to enter our park");
        }
    }
}