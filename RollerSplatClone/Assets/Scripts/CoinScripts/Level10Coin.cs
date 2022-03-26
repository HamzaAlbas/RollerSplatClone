using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Level10CoinAcquired")==1)
        {
            coin.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag(tag = "ball"))
        {
            PlayerPrefs.SetInt("Level10CoinAcquired", 1);
        }
    }
}
