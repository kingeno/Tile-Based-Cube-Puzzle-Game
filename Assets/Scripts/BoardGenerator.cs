using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{

    [Range(3, 20)] public int _boardSize;
    public static int boardSize;

    public Transform board;
    public Transform tilePrefab;
    private Transform[] tiles;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
             boardSize = _boardSize;

            foreach (Transform child in board.transform)
            {
                Destroy(child.gameObject);
            }

            tiles = new Transform[boardSize];

            for (int i = 0, z = 0; z < boardSize; z++, i++)
            {
                for (int x = 0; x < boardSize; x++)
                {
                    Transform tile = Instantiate(tilePrefab);
                    tile.SetParent(board, false);
                    tiles[i] = tile;
                    tiles[i].transform.position = new Vector3(x, 0, z);
                    tiles[i].name = "tile_" + i + x;
                }
            }
        }
    }
}
