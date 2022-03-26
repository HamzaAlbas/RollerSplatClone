using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Level3CoinAcquired")==1)
        {
            coin.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        PlayerPrefs.SetInt("Level3CoinAcquired", 1);
    }
}
