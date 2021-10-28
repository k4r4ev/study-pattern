using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    public float side = 2;
    public override float Area()
    {
        return Mathf.Pow(side, 2) / 2;
    }
    public override void Draw()
    {
        LineRenderer lineRenderer;
        if (!gameObject.GetComponent<LineRenderer>())
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }
        else
        {
            lineRenderer = gameObject.GetComponent<LineRenderer>();
            lineRenderer.SetPositions(new Vector3[0]);
            lineRenderer.positionCount = 0;
        }
        lineRenderer.material = new Material(Shader.Find("Standard"));
        lineRenderer.startColor = Color;
        lineRenderer.startWidth = 0.1F;
        lineRenderer.positionCount = 4;
        var height = Mathf.Sqrt(3 * Mathf.Pow(side, 2));
        lineRenderer.SetPosition(0, new Vector3(side / -2, height / -2, 0));
        lineRenderer.SetPosition(1, new Vector3(side / -2, height / 2, 0));
        lineRenderer.SetPosition(2, new Vector3(side / 2, height / -2, 0));
        lineRenderer.SetPosition(3, new Vector3(side / -2, height / -2, 0));
    }
    public override string toString()
    {
        return "Circle color is " + Color + " and area is : " + Area();
    }
}
