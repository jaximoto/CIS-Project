using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldmovement : MonoBehaviour
{
    [SerializeField] private float aheadPlayer;
    [SerializeField] private Transform player;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(player.position.x + aheadPlayer, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (horizontalInput > 0.01f)
            transform.position = new Vector3(player.position.x + aheadPlayer, transform.position.y, transform.position.z);
        else if (horizontalInput < -0.01f)
            transform.position = new Vector3(player.position.x - aheadPlayer, transform.position.y, transform.position.z);
        //Flip shield when up or down

        if (verticalInput > 0.01f)
            transform.position = new Vector3(player.position.x, transform.position.y + aheadPlayer, transform.position.z);
        else if (horizontalInput < -0.01f)
            transform.position = new Vector3(player.position.x, transform.position.y - aheadPlayer, transform.position.z);
        */
    }
        
}
