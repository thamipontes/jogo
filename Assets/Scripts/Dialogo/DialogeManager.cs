using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogeText;
    public Queue<string> sentences;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialoge(Dialoge dialoge)
    {
      animator.SetBool("IsOpen", true);
      nameText.text = dialoge.name;
      sentences.Clear();
      foreach(string sentence in dialoge.sentence)
      {
        sentences.Enqueue(sentence);
      }
      DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
      if(sentences.Count == 0)
      {
        EndDialoge();
        return;
      }

      string sentence = sentences.Dequeue();
      StopAllCoroutines();
      StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string sentence){
      dialogeText.text = "";
      foreach(char letter in sentence.ToCharArray())
      {
        dialogeText.text += letter;
        yield return new WaitForSecondsRealtime(0.025f);
      }
    }
    public void EndDialoge()
    {
      animator.SetBool("IsOpen", false);
    }

}
