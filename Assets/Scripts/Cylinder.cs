using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private Vector3 scale;
    private float scaleY = 0.05f;

    private void Awake()
    {
        scale = transform.localScale;
    }

    public void Grow()
    {
        scale.y += scaleY;
        transform.localScale = new Vector3(scale.x, scale.y, scale.z);
    }
}
