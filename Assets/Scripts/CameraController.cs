using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentposX;
    private Vector2 velocity = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.SmoothDamp(transform.position, new Vector2(currentposX, transform.position.y), ref velocity, speed * Time.deltaTime);
    }
    public void NewRoom(Transform _newroom)
    {

    }
}
