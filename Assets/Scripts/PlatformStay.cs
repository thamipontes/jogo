using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStay : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "platform")
        {
            transform.parent= other.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "platform")
        {
            transform.parent = null;
        }
    }
}
