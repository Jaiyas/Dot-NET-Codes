using System;
interface IPrice
{
    double CalculatePrice(int Quanity);
}
class Ingredient
{
    private const double_sodaPrice= 15;
    private const double_alcoholPrice= 500;
    private readonly int_sodaQuantity;
 private readonly int_alcoholQuantity;

 public Ingredient(int sodaQuantity, int alcoholQuantity)
    {
        this._sodaQuanity = sodaQuantity;
        this._alcoholQuanity = alcoholQuantity;
    }

    public double IngredientsAmount()
    {
        return _sodaQuanity + _alcoholQuanity;
    }

}
class BlueOcean : IPrice
{
    // your code goes here
    private const int_sodaQuantity= 2;
    private const int_alcoholQuantity= 2;
    public double CalculatePrice(int quanity)
    {
        Ingredient i = new Ingredient(_sodaQuanity, _alcoholQuanity);
        double total = i.IngredientsAmount();
        return total * quanity;
    }
}
class Mojito : IPrice
{
    // your code goes here
    private const int_sodaQuantity= 4;
    private const int_alcoholQuantity= 2;
    public double CalculatePrice(int quanity)
    {
        Ingredient i = new Ingredient(_sodaQuanity, _alcoholQuanity);
        double total = i.IngredientsAmount();
        return total * quanity;
    }

}
class PrepareBill
{
    // your code goes here
    public double CalculateDrinkPrice(Func<int, double> calculatePrice, int quanity)
    {
        return calculatePrice(quanity);
    }
}
class Source
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    }
}
