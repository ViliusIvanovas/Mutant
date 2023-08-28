public class Hand : AgeSystem
{
    public List<Finger> Fingers = new List<Finger>();

    public Hand()
    {
        int fingerNumber = new Random().Next(1, 5);

        for (int i = 0; i < fingerNumber; i++)
        {
            Fingers.Add(new Finger());
        }
    }
}