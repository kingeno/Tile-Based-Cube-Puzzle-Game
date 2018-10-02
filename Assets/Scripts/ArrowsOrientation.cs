using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsOrientation : MonoBehaviour
{

    private static Quaternion forwardArrow;
    private static Quaternion backArrow;
    private static Quaternion leftArrow;
    private static Quaternion rightArrow;

    public static void TileOrientation_Green (GameObject tile, Transform tileTransform)
        {
        forwardArrow = Quaternion.Euler(0, 0, 0);
        backArrow = Quaternion.Euler(0, 180, 0);
        leftArrow = Quaternion.Euler(0, 270, 0);
        rightArrow = Quaternion.Euler(0, 90, 0);

        if (tileTransform.rotation == forwardArrow)
        {
            tile.tag = "Forward Arrow";
        }
        if (tileTransform.rotation == backArrow)
        {
            tile.tag = "Back Arrow";
        }
        if (tileTransform.rotation == leftArrow)
        {
            tile.tag = "Left Arrow";
        }
        if (tileTransform.rotation == rightArrow)
        {
            tile.tag = "Right Arrow";
        }
    }
}
