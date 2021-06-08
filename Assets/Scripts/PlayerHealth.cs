using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth playerHealth { get; private set; }
    HUDControl hControl;

    public Animator animator;

    void Start()
    {
        //text.text = "VIDA: " + health;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    private void OnCollisionEnter2D(Collision2D other)
    {
      //if(collision.gameObject.tag == "Water")
      if(other.gameObject.CompareTag("Water"))
      {
        Debug.Log("Colider");
        Damage();
      }

    }

    public void Damage()
    {
      HUDControl.hControl.TirarVida();
      StartCoroutine(damageTime());
    }

    IEnumerator damageTime()
    {
      animator.SetBool("taSofrendo",true);
      MusicManager.playSound("machucar1");
      yield return new WaitForSecondsRealtime(0.75f);
      animator.SetBool("taSofrendo", false);
    }


}
