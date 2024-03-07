using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal, vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * 0.01f;
        vertical = Input.GetAxis("Vertical") * 0.01f;

         transform.Translate(horizontal, vertical, 0);

    }
}
