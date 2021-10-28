using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public Color Color = new Color();
    public abstract float Area();
    public abstract string toString();
    public abstract void Draw();
    public Color GetColor()
    {
        return Color;
    }
}
