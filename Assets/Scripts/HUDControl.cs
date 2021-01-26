using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDControl : MonoBehaviour
{
    public static HUDControl hControl { get; private set; }

    // Start is called before the first frame update
    public int hp = 10;
    //public int health = 100;
    //public Text text;
    // public Text resultText;
    public GameObject gameover;

    //vida por coracao
    public Image coracao;
    public GameObject coracaoObject;
    public Sprite[] sprite = new Sprite[10];

    //public Animator animator;

    //no video fala que precisa ter isso, ainda não aprendi sobre o que é não
    private void Awake()
    {
        if (hControl == null)
        {
          hControl = this;
        }
        // else
        // {
        //   Destroy(gameObject);
        // }
        // DontDestroyOnLoad(GameObject);
    }

    void Start()
    {
        //text.text = "VIDA: " + health;

        //coracao = GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TirarVida()
    {
        Debug.Log("TirouVida");

        //health -= 10;
        hp --;

        // if(hp <= 0)
        // {
        //     Debug.Log("GameOver");
        //     //resultText.gameObject.SetActive(true);
        //     GameOver.gameObject.SetActive(true);
        //     //resultText.text = "Derrota";
        // }

        Coracoes();
        //text.text = "VIDA: " + health;

    }

    public void Coracoes()
    {
      Debug.Log("coracao");
      switch(hp)
      {
        case 10:
          coracao.GetComponent<Image>().sprite = sprite[0];
          break;

        case 9:
          coracao.GetComponent<Image>().sprite = sprite[1];
          break;

        case 8:
          coracao.GetComponent<Image>().sprite = sprite[2];
          break;

        case 7:
          coracao.GetComponent<Image>().sprite = sprite[3];
          break;

        case 6:
          coracao.GetComponent<Image>().sprite = sprite[4];
          break;

        case 5:
          coracao.GetComponent<Image>().sprite = sprite[5];
          break;

        case 4:
          coracao.GetComponent<Image>().sprite = sprite[6];
          break;

        case 3:
          coracao.GetComponent<Image>().sprite = sprite[7];
          break;

        case 2:
          coracao.GetComponent<Image>().sprite = sprite[8];
          break;

        case 1:
          coracao.GetComponent<Image>().sprite = sprite[9];
          break;

        default:
          coracao.GetComponent<Image>().sprite = sprite[10];
          gameover.gameObject.SetActive(true);
          break;
      }
    }

}
