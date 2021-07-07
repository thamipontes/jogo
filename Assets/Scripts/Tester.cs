﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
  public Conversation convo;
  public MenuManager menuManager;


  public void StartConvo()
  {
    Debug.Log(PlayerPrefs.GetInt("dialogue"));

    if (PlayerPrefs.GetInt("dialogue") == 0) {
      DialogueManager.StartConversation(convo);
    }
  }
}
