using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    public float side = 4;
    public override float Area()
    {
        return Mathf.Pow((float)side, 2);
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
        lineRenderer.positionCount = 5;
        lineRenderer.SetPosition(0, new Vector3(side / -2, side / -2, 0));
        lineRenderer.SetPosition(1, new Vector3(side / -2, side / 2, 0));
        lineRenderer.SetPosition(2, new Vector3(side / 2, side / 2, 0));
        lineRenderer.SetPosition(3, new Vector3(side / 2, side / -2, 0));
        lineRenderer.SetPosition(4, new Vector3(side / -2, side / -2, 0));
    }
    public override string toString()
    {
        return "Square color is " + Color + " and area is : " + Area();
    }
}
