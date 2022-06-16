using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Sprite[] playerIcons; //caso seja 1 = X e 0 = O
    public Button[] jogoDaVelhaSpaces;
    public int[] gridMarcada;
    private int count;
    private int vezJogarCount;
    public GameObject[] linhasVermelhas;
    public GameObject panel;
    private bool alguemGanhou;
    private const int figuraX = 0;
    private const int figuraO = 1;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        vezJogarCount = 0;
        alguemGanhou = true;

        for (int i = 0; i < jogoDaVelhaSpaces.Length; i++)
        {
            jogoDaVelhaSpaces[i].interactable = true;
            jogoDaVelhaSpaces[i].GetComponent<Image>().sprite = null;
        }

        for (int i = 0; i < gridMarcada.Length; i++)
        {
            gridMarcada[i] = -100;
        }
    }

    public void jogoDaVelhaGrid(int NumeroGrid)
    {
        marcarFiguraNoGrid(NumeroGrid, figuraX);
        computerTurn();
    }

    public void ganhador()
    {
        int s1 = gridMarcada[0] + gridMarcada[1] + gridMarcada[2];
        int s2 = gridMarcada[3] + gridMarcada[4] + gridMarcada[5];
        int s3 = gridMarcada[6] + gridMarcada[7] + gridMarcada[8];
        int s4 = gridMarcada[0] + gridMarcada[3] + gridMarcada[6];
        int s5 = gridMarcada[1] + gridMarcada[4] + gridMarcada[7];
        int s6 = gridMarcada[2] + gridMarcada[5] + gridMarcada[8];
        int s7 = gridMarcada[0] + gridMarcada[4] + gridMarcada[8];
        int s8 = gridMarcada[2] + gridMarcada[4] + gridMarcada[6];

        var solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8 };

        for (int i = 0; i < solutions.Length; i++)
            if (solutions[i] == 3 * (vezJogarCount + 1))
            {
                alguemGanhou = false;
                Debug.Log("ganhou");
                escolherLinhasVermelhas(i);
                return;
            }
    }

    void computerTurn()
    {
        int randomNumber = Random.Range(0, 8);

        if (jogoDaVelhaSpaces[randomNumber].GetComponent<Button>().IsInteractable())
        {
            marcarFiguraNoGrid(randomNumber, figuraO);
        }
        else
        {
            computerTurn();
        }
    }

    void marcarFiguraNoGrid(int index, int figura)
    {
        jogoDaVelhaSpaces[index].image.sprite = playerIcons[figura];
        jogoDaVelhaSpaces[index].interactable = false;

        gridMarcada[index] = vezJogarCount + 1;
        count++;

        if (count > 4 && alguemGanhou)
        {
            ganhador();
        }

        if (count == 9 )
        {
            deuVelha();
        }

        if (vezJogarCount == 0)
        {
            vezJogarCount = 1;
        }
        else
        {
            vezJogarCount = 0;
        }
    }

    void escolherLinhasVermelhas(int index)
    {
        panel.SetActive(true);
        linhasVermelhas[index].SetActive(true);
    }

    void deuVelha()
    {
        panel.SetActive(true);
    }
}