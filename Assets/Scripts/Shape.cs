using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private Color color;
    private Vector3 position;

    Renderer m_Renderer;

    public Color Color 
    { 
        get { return color; } 
        set { color = value; }
    }

    public Vector3 Position 
    { 
        get { return position;}
        set { position = value; }
    }

    /*
    protected void Start()
    {
        //Fetch the Renderer component of the GameObject
        m_Renderer = GetComponent<Renderer>();
    }
    */

    //Click the GameObject to change the Renderer's material color
    void OnMouseUp()
    {
        m_Renderer.material.color = color;
    }

}
