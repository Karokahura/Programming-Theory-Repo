using TMPro;
using UnityEngine;

public class Cube : Shape
{
    public TextMeshProUGUI displayText;
    private void Awake()
    {
        ShapeName = "Cube";
        ShapeColor = Color.red;
    }

    public override void DisplayText()
    {
        string colorName = GetColorName(ShapeColor);
        displayText.text = $"Look at that! A {ShapeName} with color {colorName}!";
    }
}
