using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
  public TextMeshProUGUI speakerName, dialogue, navButtonText;
  public Image speakerSprite;

  private int currentIndex;
  private Conversation currentConvo;
  private static DialogueManager instance;
  private Animator anim;
  private Coroutine typing;

  private void Awake()
  {
    if(instance == null)
    {
      instance = this;
      anim = GetComponent<Animator>();
    }
    else{
      Destroy(gameObject);
    }
  }

  public static void StartConversation(Conversation convo)
  {
    instance.anim.SetBool("isOpen", true);
    instance.currentIndex = 0;
    instance.currentConvo = convo;
    instance.speakerName.text = "";
    instance.dialogue.text = "";
    instance.navButtonText.text = "";

    instance.ReadNext();
  }

  public void ReadNext()
  {
    if(currentIndex > currentConvo.GetLength())
    {
      instance.anim.SetBool("isOpen", false);
      return;
    }
    speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
    //
    // if(typing != null)
    // {
    //   typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
    // }
    StopAllCoroutines();
    instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
    speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
    currentIndex++;
  }

  private IEnumerator TypeText(string text)
  {
    dialogue.text = "";
    foreach(char letter in text.ToCharArray())
    {
      dialogue.text += letter;
      yield return new WaitForSecondsRealtime(0.025f);
    }

  }

  public void CloseDialogue()
  {
    instance.anim.SetBool("isOpen", false);
  }

}
