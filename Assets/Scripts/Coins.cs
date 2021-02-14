using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coins : MonoBehaviour
{
  
    [SerializeField] Tester teste;
    public int coins = 0;
    HUDControl hControl;
    int n;


    public TextMeshProUGUI CoinText;


    void Start()
    {
        CoinText.text = "" + coins;
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

            if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "" + coins;
                Destroy(other.gameObject);
                HUDControl.hControl.Moedas(coins);
            }

            if(coins == 53 && n == 0)
            {
                teste.StartConvo();
                n++;
            }

    }
}
