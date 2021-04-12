
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogeTrigger : MonoBehaviour
{
    public Dialoge dialoge;

    public void TriggerDialoge()
    {
      FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
    }
}
