using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI cronometro;
    public float cronometroIncial = Constante.CRONOMETRO_TEMPO;
    public float tempoAtual;
    public bool tempoAcabou;
    public GameObject jogarNovamente;

        // Start is called before the first frame update
    void Start()
    {
        tempoAtual = cronometroIncial;
    }

    // Update is called once per frame
    void Update()
    {
        if (!tempoAcabou)
        {
            ContagemRegressiva();
        }else {
            jogarNovamente.SetActive(true);
        }
    }

    void ContagemRegressiva()
    {
        tempoAtual -= 1 * Time.deltaTime;
        cronometro.text = tempoAtual.ToString("0");
        if (tempoAtual <= 10)
        {
            cronometro.color = Color.yellow;
            cronometro.fontSize = 35;
        }

        if (tempoAtual <= 5)
        {
            cronometro.color = Color.red;
            cronometro.fontSize = 40;
        }
        if (tempoAtual <= 0)
        {
            cronometro.fontSize = 50;
            tempoAtual = 0;
            tempoAcabou = true;
        }
    }
}
