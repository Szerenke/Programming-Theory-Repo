using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private int waitTime = 4;
    private float boundZ = 1.5f;

    public void Move()
    {
        Debug.Log("pos Z: " + transform.position.z);
        this.GetComponent<Rigidbody>().mass = 10;
        if (transform.position.z < boundZ)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.Impulse);
            StartCoroutine(SetForceZero());
        }
    }

    IEnumerator SetForceZero()
    {
        yield return new WaitForSeconds(waitTime);
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
