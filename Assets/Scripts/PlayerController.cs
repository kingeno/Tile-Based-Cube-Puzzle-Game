using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = false;

    private Vector3 moveForward;
    private Vector3 moveBack;
    private Vector3 moveLeft;
    private Vector3 moveRight;

    private Vector3 startPos;
    private Vector3 currentPos;

    public GameObject startTile;

    public Vector3 lastNonBlankTileType;


    void Start()
    {
        Time.timeScale = 0.05f;

        moveForward = new Vector3(0, 0, 1);
        moveBack = new Vector3(0, 0, -1);
        moveLeft = new Vector3(-1, 0, 0);
        moveRight = new Vector3(1, 0, 0);
    }

    void Update()
    {
        // look for the start tile in the scene and place the Player cube upon it if it find it
        if (startTile == null)
        {
            startTile = GameObject.FindGameObjectWithTag("Start Tile");
            startPos += (startTile.transform.position + new Vector3(0, 1, 0));
            transform.position = startPos;
        }

        // Keep pressing the right arrow to allow the player to be moved by the tiles
        if (Input.GetKey(KeyCode.RightArrow))
            canMove = true;
        else
            canMove = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Start Tile")
        {
            transform.position += moveForward;
            lastNonBlankTileType = moveForward;
        }

        if (other.tag == "End Tile")
        {

        }

        if (other.tag == "Blank Tile")
        {
            transform.position += lastNonBlankTileType;
        }

        if (other.tag == "Forward Arrow")
        {
            transform.position += moveForward;
            lastNonBlankTileType = moveForward;
        }

        if (other.tag == "Back Arrow")
        {
            transform.position += moveBack;
            lastNonBlankTileType = moveBack;
        }

        if (other.tag == "Left Arrow")
        {
            transform.position += moveLeft;
            lastNonBlankTileType = moveLeft;
        }

        if (other.tag == "Right Arrow")
        {
            transform.position += moveRight;
            lastNonBlankTileType = moveRight;
        }
    }
}
