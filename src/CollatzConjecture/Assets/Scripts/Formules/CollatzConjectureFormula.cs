public class CollatzConjectureFormula : IFormula
{
    public int Calculate( int x)
    {
        if (x % 2 == 0)
        {
            return x/2;
        }
        else
        {
            return 3 * x + 1;
        }
    }
}