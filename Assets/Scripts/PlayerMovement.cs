using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.2f;
    public Vector3 movementDirection;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("playerTransform transform.position:" + playerTransform.position);
        playerTransform.position = playerTransform.position + movementDirection * speed * Time.deltaTime;
    }
}
