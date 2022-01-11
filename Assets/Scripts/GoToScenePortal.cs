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
            PlayerPrefs.SetFloat("Ada Lovelacex", -9f);
            PlayerPrefs.SetFloat("Ada Lovelacey", 1.3f);
            PlayerPrefs.SetFloat("Ada Lovelacez", 0f);
            SceneManager.LoadScene(sceneName);
        }
    }
}
