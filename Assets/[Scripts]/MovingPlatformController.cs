using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlatformDirection
{
    HORIZONTAL,
    VERTICAL
}

public class MovingPlatformController : MonoBehaviour
{
    [Header("Movement")]
    public PlatformDirection direction;
    [Range(0.1f, 10f)]
    public float speed;
    [Range(0.1f, 10f)]
    public float distance;
    public bool isLooping;

    private Vector2 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        switch(direction)
        {
            case PlatformDirection.HORIZONTAL:
                transform.position = new Vector2(startingPosition.x + Mathf.PingPong(Time.time * speed, distance), transform.position.y);
                break;
            case PlatformDirection.VERTICAL:
                transform.position = new Vector2(transform.position.x ,startingPosition.y + Mathf.PingPong(Time.time * speed, distance));
                break;
        }
    }
}
