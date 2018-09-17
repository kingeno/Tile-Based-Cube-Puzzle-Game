using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    

	void Update () {
        if (BoardGenerator.boardSize == 3 || BoardGenerator.boardSize == 4)
        {
            transform.position = new Vector3(1, 12, -4);
        }

        if (BoardGenerator.boardSize == 5 || BoardGenerator.boardSize == 6)
        {
            transform.position = new Vector3(2, 13, -3);
        }

        if (BoardGenerator.boardSize == 7 || BoardGenerator.boardSize == 8)
        {
            transform.position = new Vector3(3, 14, -3);
        }
    }
}
