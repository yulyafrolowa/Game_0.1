using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    bool doorOpen;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D  col){
      if (col.gameObject.tag =="Player")
        {
            doorOpen = true;
            Debug.Log("Otwarte");
            DoorControl("Open");

        }
        
    }
    private void OnTriggerExit2D(Collider2D col){
        if (doorOpen)
        {
            doorOpen = false;
            Debug.Log("Zamkniente");
            DoorControl("Close");
        }


    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
