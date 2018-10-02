using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Camera m_OrthographicCamera;

    void Update()
    {
        //if (boardIsGenerated)
        //{
        if (BoardGenerator.boardSize == 3 || BoardGenerator.boardSize == 4)
        {
            transform.position = new Vector3(-6.5f, 13, -5.5f);
            Camera.main.orthographicSize = 5;
        }

        if (BoardGenerator.boardSize == 5 || BoardGenerator.boardSize == 6)
        {
            transform.position = new Vector3(-5.5f, 13, -4.5f);
            Camera.main.orthographicSize = 6;
        }

        if (BoardGenerator.boardSize == 7 || BoardGenerator.boardSize == 8)
        {
            transform.position = new Vector3(-4.5f, 13, -3.5f);
            Camera.main.orthographicSize = 7;
        }
        //}
    }
}
