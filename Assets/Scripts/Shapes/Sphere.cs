using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sphere : Shape
{
    public void Bounce()
    {
        AddRigidbody();
        this.GetComponent<Collider>().material = CreateBouncy();
    }

    private void AddRigidbody()
    {
        if (this.GetComponent<Rigidbody>() == null)
        {
            this.AddComponent<Rigidbody>();
        }
    }

    PhysicMaterial CreateBouncy()
    {
        PhysicMaterial bouncy = new PhysicMaterial();
        bouncy.dynamicFriction = 0;
        bouncy.staticFriction = 0;
        bouncy.bounciness = 1;
        bouncy.bounceCombine = PhysicMaterialCombine.Maximum;
        bouncy.frictionCombine = PhysicMaterialCombine.Average;
        return bouncy;
    }
}
