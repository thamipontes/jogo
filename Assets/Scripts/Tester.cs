﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
  public Conversation convo;

  public void StartConvo()
  {
    DialogueManager.StartConversation(convo);
  }
}
