using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Classe: GoToScene
 * Descrição: Muda para cena na colisão
 */
public class GoToScenePortal : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            //Muda para a cena passada nos parâmetros
            SceneManager.LoadScene(sceneName);
        }
    }
}
