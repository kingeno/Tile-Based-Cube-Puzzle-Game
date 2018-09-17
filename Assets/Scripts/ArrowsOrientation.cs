using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsOrientation : MonoBehaviour
{

    public Quaternion forwardArrow;
    public Quaternion backArrow;
    public Quaternion leftArrow;
    public Quaternion rightArrow;

    void Start()
    {
        forwardArrow = Quaternion.Euler(0, 0, 0);
        backArrow = Quaternion.Euler(0, 180, 0);
        leftArrow = Quaternion.Euler(0, 270, 0);
        rightArrow = Quaternion.Euler(0, 90, 0);

        if (transform.rotation == forwardArrow)
        {
            gameObject.tag = "Forward Arrow";
        }
        if (transform.rotation == backArrow)
        {
            gameObject.tag = "Back Arrow";
        }
        if (transform.rotation == leftArrow)
        {
            gameObject.tag = "Left Arrow";
        }
        if (transform.rotation == rightArrow)
        {
            gameObject.tag = "Right Arrow";
        }
    }
}
