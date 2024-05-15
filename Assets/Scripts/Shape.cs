using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private Color color;

    public Color Color 
    { 
        get { return color; } 
        set 
        {
            color = value;
            this.GetComponent<Renderer>().material.color = color;
        }
    }
}
