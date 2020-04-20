using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyboardController : Controller
{
    void Update()
    {
        PressActionKey();
        PressDirectionKey();
    }

    void PressActionKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActionKeyPressed?.Invoke();
        }
    }

    void PressDirectionKey()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            DirectionKeyPressed?.Invoke(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            DirectionKeyPressed?.Invoke(Vector3.left);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            DirectionKeyPressed?.Invoke(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            DirectionKeyPressed?.Invoke(Vector3.down);
        }
    }
}
