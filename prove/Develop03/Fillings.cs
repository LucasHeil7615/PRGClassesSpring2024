
class Fillings
{
    private string description = "\nIn this program You can load any scripture and it's accompaying refrence and memorize that scripture.\nOur program will randomly increment the amount of hidden words of that scripture for you as you press enter.\nTo start select 1. This will get a scripture that you want to memorize into a local txt file.\nThen select 2. This will clear any current scripture in the console and load a new scripture to memorize.\nTo run the program select 3. This will show you the full scripture and as you press (enter)\nthe program will randomly hide words until they are all hidden.\nTo quit the program enter 0.\n";

    public string GetDescription()
    {
        return description;
    }
}