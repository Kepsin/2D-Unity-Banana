using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BananaInteract : MonoBehaviour
{
    bool triggerActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Interact") && triggerActive) {
            startText();
        }
     }

    void OnTriggerStay2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            triggerActive = true;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            triggerActive = false;
        }
    }

    void startText() {
        
    }

}
