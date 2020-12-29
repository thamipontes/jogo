using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

	public int coins = 0;
	public Text CoinText;
	
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        CoinText.text = "Moedas: " + coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.gameObject.CompareTag("Moeda"))
    	{
    		coins++;
    		CoinText.text = "Moedas: " + coins;
    		Destroy(other.gameObject);
    		
    	}
    }
}
