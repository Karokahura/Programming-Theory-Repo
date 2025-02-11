using TMPro;
using UnityEngine;

public class Capsule : Shape
{
    public TextMeshProUGUI displayText;
    private void Awake()
    {
        ShapeName = "Capsule";
        ShapeColor = Color.yellow;
    }

    public override void DisplayText()
    {
        string colorName = GetColorName(ShapeColor);
        displayText.text = $"Look at that! A {ShapeName} with color {colorName}!";
    }
}
