using UnityEngine;
using UnityEngine.SceneManagement;

public class SalvarPosicao : MonoBehaviour
{
    public string cenaAtual;

    private void Awake()
    {
        cenaAtual = SceneManager.GetActiveScene().name;
    }

    // Start is called before the first frame update
    void Start()
    {
        FazerLoad();
    }

    public void FazerLoad()
    {
        if (PlayerPrefs.HasKey(cenaAtual + "x") &&
            PlayerPrefs.HasKey(cenaAtual + "y") &&
            PlayerPrefs.HasKey(cenaAtual + "z"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat(cenaAtual + "x") + 0.02f,
                PlayerPrefs.GetFloat(cenaAtual + "y"), PlayerPrefs.GetFloat(cenaAtual + "z"));
        }
    }

    // Update is called once per frame
    public void SalvarLocalizacao()
    {
        PlayerPrefs.SetFloat(cenaAtual + "x", transform.position.x);
        PlayerPrefs.SetFloat(cenaAtual + "y", transform.position.y);
        PlayerPrefs.SetFloat(cenaAtual + "z", transform.position.z);
    }
}
