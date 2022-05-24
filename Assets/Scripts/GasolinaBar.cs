using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasolinaBar : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Moeda"))
        {
            HUDControl.hControl.UpdateGasolinaBar(12);
            Destroy(other.gameObject);
        }
    }
    
    
}
