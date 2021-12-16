using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GeometricShape
{
    protected float width = 3.0f;
    protected float height = 5.0f;
    protected float Area;

    private string _infoShape;
    public string InfoShape
    {
        get { return _infoShape; }
        set { _infoShape = value; }
    }

    public abstract string Shape(int op);
}

public class SquareShape : GeometricShape
{
    public override string Shape(int op)
    {
        Area = width * width;
        InfoShape = "Figura: " + op.ToString() + " -> Cuadrado: \n" + "ancho = " + width + ", alto = " + width + ", Area = " + Area; ;
        Debug.Log(InfoShape);
        return InfoShape;
    }
}

public class RectShape : GeometricShape
{
    public override string Shape(int op)
    {
        Area = width * height;
        InfoShape = "Figura: " + op.ToString() + " -> Rectangulo: \n" + "ancho = " + width + ", alto = " + height + ", Area = " + Area;
        Debug.Log(InfoShape);
        return InfoShape;
    }
}

public class TriShape : GeometricShape
{
    public override string Shape(int op)
    {
        Area = width * height / 2;
        InfoShape = "Figura: " + op.ToString() + " -> Triangulo: \n " + "ancho = " + width + ", alto = " + height + ", Area = " + Area;
        Debug.Log(InfoShape);
        return InfoShape;
    }
}
