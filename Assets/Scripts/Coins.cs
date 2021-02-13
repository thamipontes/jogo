using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coins : MonoBehaviour
{

    public int coins = 0;


    public TextMeshProUGUI CoinText;


    void Start()
    {
        CoinText.text = "Moedas: " + coins;
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other) {

            if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "Moedas: " + coins;
                Destroy(other.gameObject);
            }

        }
}
