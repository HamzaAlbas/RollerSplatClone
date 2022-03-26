using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Level4CoinAcquired")==1)
        {
            coin.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        PlayerPrefs.SetInt("Level4CoinAcquired", 1);
    }
}
