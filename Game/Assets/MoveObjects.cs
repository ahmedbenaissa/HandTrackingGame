using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public GameObject[] fingers; // Array of finger game objects
    public GameObject objectToMove; // The object to move

    private int fingerCountInsideBox = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fingerCountInsideBox = 0;

        foreach (GameObject finger in fingers)
        {
            if (finger.GetComponent<Collider>().bounds.Intersects(objectToMove.GetComponent<Collider>().bounds))
            {
                fingerCountInsideBox++;
            }
        }

        if (fingerCountInsideBox >= 2)
        {
            // Attach the object to one of the fingers
            AttachToObject(fingers[0]); // Choose the first finger as the anchor
        }
        else
        {
            // Release the object from the finger
            ReleaseObject();
        }
    }

    private void AttachToObject(GameObject finger)
    {
        objectToMove.transform.position = finger.transform.position;
        objectToMove.transform.rotation = finger.transform.rotation;
        objectToMove.transform.parent = finger.transform;
    }

    private void ReleaseObject()
    {
        objectToMove.transform.parent = null;
    }

}
