using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToScene2 : MonoBehaviour
{
    public Image planetaAtivado;
    public Image planetaDesativado;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Planeta 2") == 2)
        {
            planetaAtivado.gameObject.SetActive(true);
            planetaDesativado.gameObject.SetActive(false);
        }
    }

}
