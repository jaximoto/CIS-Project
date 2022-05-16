using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(collision.transform.position.x < transform.position.x)
            {
                cam.NewRoom(nextRoom);
            }
            else
            {
                cam.NewRoom(previousRoom);
            }
        }
    }
}
