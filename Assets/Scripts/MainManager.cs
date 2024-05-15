using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    private Cube cube;
    private Cylinder cylinder;
    private Sphere sphere;
    Camera m_Camera;

    void Awake()
    {
        m_Camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        GetShapeObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetClickedObject();
        }
    }

    void GetShapeObjects()
    {
        cube = GameObject.Find("Cube").GetComponent<Cube>();
        cylinder = GameObject.Find("Cylinder").GetComponent<Cylinder>();
        sphere = GameObject.Find("Sphere").GetComponent<Sphere>();
    }

    void SetClickedObject()
    {      
        Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            SwithObject(hit.transform.gameObject);
        }
    }

    void SwithObject(GameObject shapeObject)
    {
        switch(shapeObject.name)
        {
            case "Cube":
                {
                    SetShapeColor(cube);
                    cube.Move();
                    break;
                }
            case "Cylinder":
                {
                    SetShapeColor(cylinder);
                    cylinder.Grow();
                    break;
                }
            case "Sphere":
                {
                    SetShapeColor(sphere);
                    sphere.Bounce();
                    break;
                }
            default:
                {
                    break;
                }
        }

    }

    void SetShapeColor(Shape shape)
    {
        shape.Color = ColorManager.NewColor;
    }
}
