class Costume
{
    // attributes (member variables)

    public string _headWear;
    public string _gloves;
    public string _shoes;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accessory;

    // behaviors
    public void ShowWardrobe()
    {
        string result = $"";
        result += $"Head Wear: {_headWear}\n";
        result += $"Gloves: {_gloves}\n";
        result += $"Shoes: {_shoes}\n";
        result += $"Upper Garmet: {_upperGarment}\n";
        result += $"Lower Garmet: {_lowerGarment}\n";
        result += $"Accessory: {_accessory}";
        Console.WriteLine(result);
    }

}