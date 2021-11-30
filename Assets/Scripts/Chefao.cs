using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chefao : MonoBehaviour
{
    public DialogueManager _dialogueManager;
    public GameObject chefao;

    private bool dialogoFechado = false;

    void Start()
    {
        dialogoFechado = _dialogueManager.anim.GetBool("isOpen");
    }

    void Update()
    {
        if(!dialogoFechado) {
            Instantiate(chefao, transform.position, transform.rotation);
        }
    }
}
