using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text coinDisplayText;
    private int _currentCoins;
    [SerializeField] private int levelCoin;
    [SerializeField] private Animator coinAnim;
    [SerializeField] private AudioClip coinAcq;
    [SerializeField] private AudioSource aS;    

    private void Start()
    {
        aS.clip = coinAcq;
        if (PlayerPrefs.HasKey("TNCoin"))
        {
            _currentCoins = PlayerPrefs.GetInt("TNCoin");
        }
        coinDisplayText.text = PlayerPrefs.GetInt("TNCoin").ToString();

       
    }


    private void OnTriggerEnter(Collider col)
    {
        coinAnim.SetTrigger("Acquired");
        aS.Play();
        _currentCoins += levelCoin;
        PlayerPrefs.SetInt("TNCoin", _currentCoins);
        coinDisplayText.text = PlayerPrefs.GetInt("TNCoin").ToString();
        gameObject.GetComponent<SphereCollider>().enabled = false;
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
