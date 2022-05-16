using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentposX;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Room camera
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentposX, transform.position.y, transform.position.z), ref velocity, speed);

        //follow player
        transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }
    public void NewRoom(Transform _newroom)
    {
        currentposX = _newroom.position.x;
    }
}
