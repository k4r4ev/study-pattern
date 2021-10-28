using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField;


    public void DrawShape()
    {
        ShapeFactory shapeFactory = FindObjectOfType<ShapeFactory>(); //get an object  and call its draw method.

        Shape shape = shapeFactory.CreatePolygon(int.Parse(InputField.text));

        shape.Draw(); //вызов метода рисования по холсту
    }
}
