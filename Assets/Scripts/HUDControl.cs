using UnityEngine;
using UnityEngine.UI;

/*
 * Classe: HUDControl
 * Descrição: Controla a vida do player e suas respectivas imagens e imagem das moedas
 */
public class HUDControl : MonoBehaviour
{
    public static HUDControl hControl { get; private set; }

    //Vida do player
    public int hp = 10;

    //Atributo do objeto gameover
    public GameObject gameover;

    //Imagem moedas
    public Image moeda;

    //Imagem dos corações
    public Image coracao;
  
    public Sprite[] sprite = new Sprite[10];
    public Sprite[] moedaSprite = new Sprite[54];

    //Atributo do objeto ame
    public GameObject ame;

    public Transform gasolinaBarTransform;

    public static Vector3 gasolinaBarScale;
    private Vector3 gasolinaBarScaleAtual;

    //Garante que hControl sempre tenha o valor this
    private void Awake()
    {
        if (hControl == null)
        {
            hControl = this;
        }
    }
    
    public void UpdateGasolinaBar(float porcentagem)
    {
      gasolinaBarScale.x = gasolinaBarScale.x + porcentagem;
      gasolinaBarScale.y = 275f;
      gasolinaBarScale.z = 357f;
      if (gasolinaBarScale.x < 240)
      {
        gasolinaBarTransform.localScale = gasolinaBarScale;
      }
    }
    
    public static void SalvaGasolina(){
      PlayerPrefs.SetFloat("gasolinaX",  gasolinaBarScale.x);
      PlayerPrefs.SetFloat("gasolinaY",  gasolinaBarScale.y);
      PlayerPrefs.SetFloat("gasolinaZ",  gasolinaBarScale.z);
      PlayerPrefs.Save();
    }

    public static Vector3 GetGasolina()
    {
        gasolinaBarScale.x = PlayerPrefs.GetFloat("gasolinaX");
        gasolinaBarScale.y = PlayerPrefs.GetFloat("gasolinaY");
        gasolinaBarScale.z = PlayerPrefs.GetFloat("gasolinaZ");
        return gasolinaBarScale;
    }

    /*
     * Nome: TirarVida
     * Parâmetro: não há
     * Descrição: Tira vida do player, se a vida chegar a 0 destrói o player
     */
    public void TirarVida()
    {
        Debug.Log("TirouVida");
        hp --;

        //Se vida do player menor ou igual a 1, carrega tela de derrota e destrói player
        if(hp <= 1)
        {
            gameover.gameObject.SetActive(true);
            Destroy(ame);
            Coins.coins = 0;
            Coins.SalvaMoedas();
            SalvaGasolina();
        }

        Coracoes();
    }

    /*
     * Nome: Coracoes
     * Parâmetro: não há
     * Descrição: Carrega imagem dos corações correspondeste à vida
     */
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

        // default:
        //   coracao.GetComponent<Image>().sprite = sprite[10];
        //   gameover.gameObject.SetActive(true);
        //   break;
      }
    }

    /*
     * Nome: Coracoes
     * Parâmetro: não há
     * Descrição: Carrega imagem das moedas correspondestes à quantidade coletada
     */
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
