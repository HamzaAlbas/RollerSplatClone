using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    private int _playerMoney;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("TNCoin"))
        {
            _playerMoney = PlayerPrefs.GetInt("TNCoin");
        }
    }


}
