public class Arm : AgeSystem
{
    public List<Hand> Hands = new List<Hand>();

    public Arm()
    {
        int handNumber = Age / 10;

        for (int i = 0; i < handNumber; i++)
        {
            Hands.Add(new Hand());
        }
    }
}