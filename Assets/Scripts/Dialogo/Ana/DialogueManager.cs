using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using PartII;
using TMPro;

public class DialogueManager : MonoBehaviour
{
  public TextMeshProUGUI speakerName, dialogue, navButtonText;
  public Image speakerSprite;
  public Animator anim;

  // [SerializeField] PlayerMovimentation ameMoviment;
  private int currentIndex;
  private Conversation currentConvo;
  private static DialogueManager instance;
  private Coroutine typing;

  public int counter = 0;


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
    // play "open" audio
    MusicManager.playSound("open");
    // instance.anim.SetBool("isOpen", true);
    var child = instance.transform.GetChild(0);
    child.gameObject.SetActive(true);
    // instance.ameMoviment.MoveRightFalse();
    // instance.ameMoviment.MoveLeftFalse();
    instance.currentIndex = 0;
    instance.currentConvo = convo;
    instance.speakerName.text = "";
    instance.dialogue.text = "";
    instance.navButtonText.text = "";

    instance.ReadNext();
  }

  public void ButtonReadNext()
  {
    instance.counter++;
    if(instance.counter == 1)
    {
      ReadNext();
    } else
    {
      StopAllCoroutines();
      ShowNextLine();
    }
  }

  public void ReadNext()
  {
    instance.counter++;
    if(currentIndex > currentConvo.GetLength())
    {
      // play "close" audio
      MusicManager.playSound("close");
      // instance.anim.SetBool("isOpen", false);
      var child = instance.transform.GetChild(0);
      child.gameObject.SetActive(false);
      instance.counter = 0;
      Time.timeScale = 1;
    }
    speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

    StopAllCoroutines();
    instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
    speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
    Time.timeScale = 0;

  }

  private IEnumerator TypeText(string text)
  {
    dialogue.text = "";
    foreach(char letter in text.ToCharArray())
    {
      dialogue.text += letter;
      yield return new WaitForSecondsRealtime(0.025f);
    }
    currentIndex++;
    instance.counter = 0;
  }

  public void ShowNextLine()
  {
    if(currentIndex > currentConvo.GetLength())
    {
      // instance.anim.SetBool("isOpen", false);
      var child = instance.transform.GetChild(0);
      child.gameObject.SetActive(false);
      instance.counter = 0;
      Time.timeScale = 1;
    }

    speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
    dialogue.text = currentConvo.GetLineByIndex(currentIndex).dialogue;
    speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
    currentIndex++;
    instance.counter = 0;
    Time.timeScale = 0;
  }

  public void CloseDialogue()
  {
    // play "close" audio
    MusicManager.playSound("close");
    // instance.anim.SetBool("isOpen", false);
    var child = instance.transform.GetChild(0);
    child.gameObject.SetActive(false);
    Time.timeScale = 1;

  }

}
