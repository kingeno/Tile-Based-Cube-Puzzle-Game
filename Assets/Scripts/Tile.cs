using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public TileTypeName Type;

    public Transform blankTile;
    public Transform startTile;
    public Transform endTile;


    void Update()
    {
        TileType[] Types = {
    BlankTile,
    StartTile,
    EndTile,
    ForwardArrow,
    BackArrow,
    RightArrow,
    LeftArrow
    };

        TileType t = Types[(int)Type];
        if (Input.GetKeyDown(KeyCode.G))
        {
            t();
        }
    }

    public void BlankTile()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        gameObject.tag = "Blank Tile";
        gameObject.name = "Blank Tile";
        Transform tile = Instantiate(blankTile);
        tile.SetParent(transform, false);
    }

    public void StartTile()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        gameObject.tag = "Start Tile";
        gameObject.name = "Start Tile";
        Transform tile = Instantiate(startTile);
        tile.SetParent(transform, false);
    }

    public void EndTile()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        gameObject.tag = "End Tile";
        gameObject.name = "End Tile";
        Transform tile = Instantiate(endTile);
        tile.SetParent(transform, false);
    }

    public void ForwardArrow()
    {
        gameObject.tag = "Forward Arrow";
    }

    public void BackArrow()
    {
        gameObject.tag = "Back Arrow";
    }

    public void LeftArrow()
    {
        gameObject.tag = "Left Arrow";
    }

    public void RightArrow()
    {
        gameObject.tag = "Right Arrow";
    }
}
