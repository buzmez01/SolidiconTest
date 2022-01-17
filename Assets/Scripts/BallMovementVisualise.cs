using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementVisualise : MonoBehaviour
{

    [SerializeField]
    public float distance = -100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*RaycastHit hit; // = Physics.Raycast(transform.position, transform.right, distance);
        Ray collidedRay = new Ray(transform.position, transform.right);

        //Debug.DrawRay(transform.position, transform.right * distance);
        if (Physics.Raycast(collidedRay, out hit, distance))
        {
            //if (hit.collider.tag == "Player")
            //{
                Debug.DrawLine(transform.position, hit.point, Color.blue);
            //}

        }*/

    }
}
