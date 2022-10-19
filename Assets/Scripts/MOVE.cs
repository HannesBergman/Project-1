using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * 5 * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * 5 * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }
        }
        
    }
}
