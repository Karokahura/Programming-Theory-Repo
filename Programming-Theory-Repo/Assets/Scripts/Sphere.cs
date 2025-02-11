using TMPro;
using UnityEngine;

public class Sphere : Shape
{
    public TextMeshProUGUI displayText;
    private void Awake()
    {
        ShapeName = "Sphere";
        ShapeColor = Color.blue;
    }

    public override void DisplayText()
    {
        string colorName = GetColorName(ShapeColor);
        displayText.text = $"Look at that! A {ShapeName} with color {colorName}!";
    }
}
