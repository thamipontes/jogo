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
    public Image moeda;
    //vida por coracao
    public Image coracao;
    //public GameObject coracaoObject;
    public Sprite[] sprite = new Sprite[10];
    public Sprite[] moedaSprite = new Sprite[54];

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

        if(hp <= 1)
        {
        //     Debug.Log("GameOver");
        //     //resultText.gameObject.SetActive(true);
          gameover.gameObject.SetActive(true);
        //     //resultText.text = "Derrota";
        }

        Coracoes();
        //text.text = "VIDA: " + health;

    }

    public void Coracoes()
    {
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

    public void Moedas(int a)
    {
      switch(a)
      {
        case 0:
          moeda.GetComponent<Image>().sprite = moedaSprite[0];
          break;

        case 1:
          moeda.GetComponent<Image>().sprite = moedaSprite[1];
          break;

        case 2:
          moeda.GetComponent<Image>().sprite = moedaSprite[2];
          break;

        case 3:
          moeda.GetComponent<Image>().sprite = moedaSprite[3];
          break;

        case 4:
          moeda.GetComponent<Image>().sprite = moedaSprite[4];
          break;

        case 5:
          moeda.GetComponent<Image>().sprite = moedaSprite[5];
          break;

        case 6:
          moeda.GetComponent<Image>().sprite = moedaSprite[6];
          break;

        case 7:
          moeda.GetComponent<Image>().sprite = moedaSprite[7];
          break;

        case 8:
          moeda.GetComponent<Image>().sprite = moedaSprite[8];
          break;

        case 9:
          moeda.GetComponent<Image>().sprite = moedaSprite[9];
          break;

        case 10:
          moeda.GetComponent<Image>().sprite = moedaSprite[10];
          break;

        case 11:
          moeda.GetComponent<Image>().sprite = moedaSprite[11];
          break;

        case 12:
          moeda.GetComponent<Image>().sprite = moedaSprite[12];
          break;

        case 13:
          moeda.GetComponent<Image>().sprite = moedaSprite[13];
          break;

        case 14:
          moeda.GetComponent<Image>().sprite = moedaSprite[14];
          break;

        case 15:
          moeda.GetComponent<Image>().sprite = moedaSprite[15];
          break;

        case 16:
          moeda.GetComponent<Image>().sprite = moedaSprite[16];
          break;

        case 17:
          moeda.GetComponent<Image>().sprite = moedaSprite[17];
          break;

        case 18:
          moeda.GetComponent<Image>().sprite = moedaSprite[18];
          break;

        case 19:
          moeda.GetComponent<Image>().sprite = moedaSprite[19];
          break;

        case 20:
          moeda.GetComponent<Image>().sprite = moedaSprite[20];
          break;

        case 21:
          moeda.GetComponent<Image>().sprite = moedaSprite[21];
          break;

        case 22:
          moeda.GetComponent<Image>().sprite = moedaSprite[22];
          break;

        case 23:
          moeda.GetComponent<Image>().sprite = moedaSprite[23];
          break;

        case 24:
          moeda.GetComponent<Image>().sprite = moedaSprite[24];
          break;

        case 25:
          moeda.GetComponent<Image>().sprite = moedaSprite[25];
          break;

        case 26:
          moeda.GetComponent<Image>().sprite = moedaSprite[26];
          break;

        case 27:
          moeda.GetComponent<Image>().sprite = moedaSprite[27];
          break;

        case 28:
          moeda.GetComponent<Image>().sprite = moedaSprite[28];
          break;

        case 29:
          moeda.GetComponent<Image>().sprite = moedaSprite[29];
          break;

        case 30:
          moeda.GetComponent<Image>().sprite = moedaSprite[10];
          break;

        case 31:
          moeda.GetComponent<Image>().sprite = moedaSprite[31];
          break;

        case 32:
          moeda.GetComponent<Image>().sprite = moedaSprite[32];
          break;

        case 33:
          moeda.GetComponent<Image>().sprite = moedaSprite[33];
          break;

        case 34:
          moeda.GetComponent<Image>().sprite = moedaSprite[34];
          break;

        case 35:
          moeda.GetComponent<Image>().sprite = moedaSprite[35];
          break;

        case 36:
          moeda.GetComponent<Image>().sprite = moedaSprite[36];
          break;

        case 37:
          moeda.GetComponent<Image>().sprite = moedaSprite[37];
          break;

        case 38:
          moeda.GetComponent<Image>().sprite = moedaSprite[38];
          break;

        case 39:
          moeda.GetComponent<Image>().sprite = moedaSprite[39];
          break;

        case 40:
          moeda.GetComponent<Image>().sprite = moedaSprite[40];
          break;

        case 41:
          moeda.GetComponent<Image>().sprite = moedaSprite[41];
          break;

        case 42:
          moeda.GetComponent<Image>().sprite = moedaSprite[42];
          break;

        case 43:
          moeda.GetComponent<Image>().sprite = moedaSprite[43];
          break;

        case 44:
          moeda.GetComponent<Image>().sprite = moedaSprite[44];
          break;

        case 45:
          moeda.GetComponent<Image>().sprite = moedaSprite[45];
          break;

        case 46:
          moeda.GetComponent<Image>().sprite = moedaSprite[46];
          break;

        case 47:
          moeda.GetComponent<Image>().sprite = moedaSprite[47];
          break;

        case 48:
          moeda.GetComponent<Image>().sprite = moedaSprite[48];
          break;

        case 49:
          moeda.GetComponent<Image>().sprite = moedaSprite[49];
          break;

        case 50:
          moeda.GetComponent<Image>().sprite = moedaSprite[50];
          break;

        case 51:
          moeda.GetComponent<Image>().sprite = moedaSprite[51];
          break;

        case 52:
          moeda.GetComponent<Image>().sprite = moedaSprite[52];
          break;

        case 53:
          moeda.GetComponent<Image>().sprite = moedaSprite[53];
          break;

        default:
          moeda.GetComponent<Image>().sprite = moedaSprite[54];
          break;
      }
    }

}
