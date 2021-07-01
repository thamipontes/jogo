using TMPro;
using UnityEngine;

/*
 * Classe: Coins
 * Descrição: Contagem das moedas adquiridas no jogo
 */
public class Coins : MonoBehaviour
{
    //Expõe um campo para conectar o Script Tester e usar suas funções/atributos
    [SerializeField] Tester teste;

    //Atributo de contagem das moedas
    public int coins = 0;

    //Declaração da classe HUDControl
    HUDControl hControl;

    //Atributo para garantir que o if seja executado uma única vez
    int n;

    //Atributo recebe o texto que irá para interface gráfica
    public TextMeshProUGUI CoinText;


    void Start()
    {
        //Ao iniciar o jogo, mostra na tela 0 moedas
        CoinText.text = "" + coins;
    }

    /*
     * Nome: OnCollisionEnter2D
     * Parâmetro: Objeto colidido
     * Descrição: função que percebe que houve uma colisão entre dois ou mais objetos
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*
         * Se o objeto colidido tiver a tag moeda, acrescenta
         * quantidade de moeda e a mostra na interface gráfica e destrói o objeto moeda
         */
        if (other.gameObject.CompareTag("Moeda"))
        {
            
            coins++;
            CoinText.text = "" + coins;
            Destroy(other.gameObject);
            HUDControl.hControl.Moedas(coins);
            MusicManager.playSound("coin1");
        }

        //Se quantidade de moedas for igual a 53, chama-se um dialogo
        if (coins == 53 && n == 0)
        {
            teste.StartConvo();
            n++;
        }
    }
}
