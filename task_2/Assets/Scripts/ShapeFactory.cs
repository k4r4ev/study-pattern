using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFactory: MonoBehaviour
{
    public Shape CreatePolygon(int numberOfSides)
    {

        if (numberOfSides == 3)
        {

            var shape = gameObject.AddComponent<Rectangle>();
            return shape;

        }
        else if (numberOfSides == 4)
        {

            var shape = gameObject.AddComponent<Square>();
            return shape;

        }
        return null;
    }
}

