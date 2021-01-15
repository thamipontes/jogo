using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth playerHealth { get; private set; }

    // Start is called before the first frame update
    private int health = 100;
    public Text text;
    public Text resultText;
    public Button button;

    public Animator animator;

    void Start()
    {
        text.text = "VIDA: " + health;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject.CompareTag("Water"))
      {

        TirarVida();

      }

      if(health <= 0)
      {
        resultText.gameObject.SetActive(true);
   			button.gameObject.SetActive(true);
   			resultText.text = "Derrota";
      }
    }

    public void TirarVida()
    {
        health -= 10;
        text.text = "VIDA: " + health;
        Damage();
    }

    public void Damage()
    {
      StartCoroutine(damageTime());
    }

    IEnumerator damageTime()
    {
      animator.SetBool("taSofrendo",true);
      yield return new WaitForSecondsRealtime(0.75f);
      animator.SetBool("taSofrendo", false);
    }

}
