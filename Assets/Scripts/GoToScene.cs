using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Classe: GoToScene
 * Descrição: Muda para cena
 */
public class GoToScene : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        //Muda para a cena passada nos parâmetros
        SceneManager.LoadScene(sceneName);
    }
}
