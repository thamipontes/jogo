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

    //vida por coracao
    public Image coracao;
    public GameObject coracaoObject;
    public Sprite[] sprite = new Sprite[10];

    public Animator animator;


    void Start()
    {
        text.text = "VIDA: " + health;
        animator = GetComponent<Animator>();
        coracao = GetComponent<Image>();
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
        Coracoes();
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

    public void Coracoes()
    {
      switch(health)
      {
        case 100:
          coracao.sprite = sprite[0];
          break;

        case 90:
          coracao.sprite = sprite[1];
          break;

        case 80:
          coracao.sprite = sprite[2];
          break;

        case 70:
          coracao.sprite = sprite[3];
          break;

        case 60:
          coracao.sprite = sprite[4];
          break;

        case 50:
          coracao.sprite = sprite[5];
          break;

        case 40:
          coracao.sprite = sprite[6];
          break;

        case 30:
          coracao.sprite = sprite[7];
          break;

        case 20:
          coracao.sprite = sprite[8];
          break;

        case 10:
          coracao.sprite = sprite[9];
          break;

        default:
          coracao.sprite = sprite[10];
          break;
      }
    }

}
