using System;
using UnityEngine;

public class Level1Coin : MonoBehaviour
{
    
    [SerializeField] private GameObject coin;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Level1CoinAcquired")==1)
        {
            coin.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        PlayerPrefs.SetInt("Level1CoinAcquired", 1);
    }
}
