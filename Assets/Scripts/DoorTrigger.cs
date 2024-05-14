using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Transform door;

    public Vector3 closedPosition = new Vector3(.51f, 3.60f, 0f);
    public Vector3 openedPosition = new Vector3(.51f, 7f, 0f);

    public float openSpeed = 6;

    private bool open = false;

    void Start()
    {

    }

    void Update()
    {
      if (open)
        {
            door.position = Vector3.Lerp(door.position, openedPosition, Time.deltaTime * openSpeed);
        }  
      else
        {
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoor();
            Debug.Log("The door is being touched");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CloseDoor();
            Debug.Log("the door is closed");
        }
    }
    public void CloseDoor()
    {
        open = false;
    }
    public void OpenDoor()
    {
        open= true;
    }
}
