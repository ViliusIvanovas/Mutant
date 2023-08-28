public class Mutant
{
    public string Name;
    public List<Arm> Arms = new List<Arm>();
    public List<Leg> Legs = new List<Leg>();
    public List<Head> Heads = new List<Head>();

    public Mutant(string name)
    {
        Name = name;

        int armNumber = new Random().Next(1, 5);
        int legNumber = new Random().Next(1, 5);
        int headNumber = 2;

        for (int i = 0; i < armNumber; i++)
        {
            Arms.Add(new Arm());
        }

        for (int i = 0; i < legNumber; i++)
        {
            Legs.Add(new Leg());
        }

        for (int i = 0; i < headNumber; i++)
        {
            Heads.Add(new Head());
        }
    }

    public void GetInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Arms: " + Arms.Count);
        for (int i = 0; i < Arms.Count; i++)
        {
            Arm arm = Arms[i];
            if (arm.Hands.Count == 1)
            {
                Console.WriteLine("  Arm" + i + " has " + arm.Hands.Count + " hand.");
            }
            else
            {
                Console.WriteLine("  Arm" + i + " has " + arm.Hands.Count + " hands.");
            }


            for (int j = 0; j < arm.Hands.Count; j++)
            {
                Hand hand = arm.Hands[j];
                if (hand.Fingers.Count == 1)
                {
                    Console.WriteLine("    Hand" + j + " has " + hand.Fingers.Count + " Finger.");
                }
                else
                {
                    Console.WriteLine("    Hand" + j + " has " + hand.Fingers.Count + " Fingers.");
                }
            }
        }

        Console.WriteLine("Legs: " + Legs.Count);
        Console.WriteLine("Heads: " + Heads.Count);
        for (int i = 0; i < Heads.Count; i++)
        {
            Head head = Heads[i];
            if (head.Ears.Count == 1)
                {
                    Console.WriteLine("  Head" + i + " has " + head.Ears.Count + " ear.");
                }
                else
                {
                    Console.WriteLine("  Head" + i + " has " + head.Ears.Count + " ears.");
                }
            
            if (head.Eyes.Count == 1)
                {
                    Console.WriteLine("  Head" + i + " had " + head.Eyes.Count + " eye.");
                }
                else
                {
                    Console.WriteLine("  Head" + i + " had " + head.Eyes.Count + " eyes.");
                }   
        }

        Console.WriteLine(@"
        ");
    }

    public void Walk()
    {
        for (int i = 0; i < Legs.Count; i++)
        {
            Leg leg = Legs[i];

            leg.Move();
        }
    }

    public void Greet(Mutant other)
    {
        Console.WriteLine("Hi, " + other.Name + ". My name is: " + Name);
    }

    public int GetAverageAge()
    {
        List<int> ages = new List<int>();

        for (int i = 0; i < Arms.Count; i++)
        {
            Arm arm = Arms[i];
            ages.Add(arm.Age);

            for (int j = 0; j < arm.Hands.Count; j++)
            {
                Hand hand = arm.Hands[j];
                ages.Add(hand.Age);
            }
        }

        for (int i = 0; i < Legs.Count; i++)
        {
            Leg leg = Legs[i];
            ages.Add(leg.Age);
        }

        for (int i = 0; i < Heads.Count; i++)
        {
            Head head = Heads[i];

            ages.Add(head.Age);

            for (int j = 0; j < head.Ears.Count; j++)
            {
                Ear ear = head.Ears[j];
                ages.Add(ear.Age);
            }
            
            for (int j = 0; j < head.Eyes.Count; j++)
            {
                Eye eye = head.Eyes[j];
                ages.Add(eye.Age);
            }
        }

        int totalAge = 0;

        for (int i = 0; i < ages.Count; i++)
        {
            totalAge += ages[i];
        }

        int result = totalAge / ages.Count();

        return result;
    }
}