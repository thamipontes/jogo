using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteVoltarCena : MonoBehaviour
{

    public GameObject portal;

    public Transform portalPosition;

    public void InstanciarPortal()
    {
        Instantiate(portal, portalPosition.transform.position, transform.rotation);

    }

}
