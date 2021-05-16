using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static AudioClip _audioCoin, _audioPulo;
    public static AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioCoin = Resources.Load<AudioClip>("MOEDAS_01");
        _audioPulo = Resources.Load<AudioClip>("PULO_01");
        
    }

    public static void playSound (string som)
    {
        switch (som)
        {
            case "coin1":
                _audioSource.PlayOneShot(_audioCoin);
                _audioSource.volume = 0.3f;
                break;
            case "pulo1":
                _audioSource.PlayOneShot(_audioPulo);
                break;
        }
    }


    // public static void comprasShein(string roupa)
    // {
    //     switch (roupa)
    //     {
    //         case "vestido": print("Tais");
    //             break;
    //         case "jeans": print("Ana Sofia");
    //             break;
    //         case "short": print("Ana julia");
    //             break;
    //         default: print("Hanani");
    //             break;
    //     }
    // }

    // bool somosBonitas()
    // {
    //     return true;
    // }

    // void elogio()
    // {
    //     printf("SOMOS GOSTOSAS");
    // }

    // int idadeAnaSofia()
    // {
    //     return 85;
    // }
}