using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shields : MonoBehaviour
{
    [SerializeField] private float aheadPlayer;
    [SerializeField] private Transform player;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x + aheadPlayer, player.position.y, player.position.z);
    }

    
    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0.01f)
            transform.position = new Vector3(player.position.x + aheadPlayer, player.position.y, player.position.z);
        else if (horizontalInput < -0.01f)
            transform.position = new Vector3(player.position.x - aheadPlayer, player.position.y, player.position.z);
        //Flip shield when up or down

        if (verticalInput > 0.01f)
            transform.position = new Vector3(player.position.x, player.position.y + aheadPlayer, player.position.z);
        else if (verticalInput < -0.01f)
            transform.position = new Vector3(player.position.x, player.position.y - aheadPlayer, player.position.z);
    }
}
