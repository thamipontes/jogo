using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFinal : MonoBehaviour
{
    [SerializeField] GoToScene goToScene;
    public GameObject demo, credito, equipe;
    private int i = 0;

    public void ProximoTexto()
    {
        if(i == 0)
        {
            demo.gameObject.SetActive(true);
            i++;
        }
        else if(i == 1)
        {
            Credito();
            i++;
        } else
        {
          goToScene.ChangeScene("Ada - Menu");
        }
    }

    public void Credito()
    {
        demo.gameObject.SetActive(false);
        credito.gameObject.SetActive(true);
        equipe.gameObject.SetActive(true);
    }

}
