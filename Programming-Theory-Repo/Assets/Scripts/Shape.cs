using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    protected virtual void Start()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    public abstract void DisplayText();

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected string GetColorName(Color color)
    {
        if (color == Color.yellow) return "Yellow";
        if (color == Color.red) return "Red";
        if (color == Color.blue) return "Blue";
        return "unknown color";
    }
}
