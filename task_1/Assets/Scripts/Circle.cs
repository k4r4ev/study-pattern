using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public float radius;
    public override float Area()
    {
        return Mathf.PI * Mathf.Pow((float)radius, 2);
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
        float theta_scale = 0.01f;
        lineRenderer.material = new Material(Shader.Find("Standard"));
        lineRenderer.startColor = Color;
        lineRenderer.startWidth = 0.1F;
        lineRenderer.positionCount = 1;
        int i = 0;
        for (float theta = 0; theta < 2 * Mathf.PI; theta += theta_scale)
        {
            var x = radius * Mathf.Cos(theta);
            var y = radius * Mathf.Sin(theta);
            Vector3 pos = new Vector3(x, y, 0);
            lineRenderer.SetPosition(i, pos);
            lineRenderer.positionCount += 1;
            i += 1;
        }
        lineRenderer.SetPosition(i, lineRenderer.GetPosition(i - 1));
    }
    public override string toString()
    {
        return "Circle color is " + Color + " and area is : " + Area();
    }
}
