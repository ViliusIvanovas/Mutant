public class Head : AgeSystem
{
    public List<Ear> Ears = new List<Ear>();
    public List<Eye> Eyes = new List<Eye>();

    public Head()
    {
        int earNumber = 1;
        int eyeNumber = new Random().Next(1, 5);

        for (int i = 0; i < earNumber; i++)
        {
            Ears.Add(new Ear());
        }

        for (int i = 0; i < eyeNumber; i++)
        {
            Eyes.Add(new Eye());
        }
    }
}