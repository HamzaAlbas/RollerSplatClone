using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip menuMusic;
    public AudioClip shopOpen;
    public AudioClip shopClose;
    public AudioClip shopBought;
    public AudioClip coinAcquired;
    public AudioClip buttonClick;

    public void MainMenu()
    {
        audioSource.clip = menuMusic;
        audioSource.Play();
    }

    public void ShopOpen()
    {
        audioSource.clip = shopOpen;
        audioSource.Play();
    }

    public void ShopClose()
    {
        audioSource.clip = shopClose;
        audioSource.Play();
    }

    public void ShopBought()
    {
        audioSource.clip = shopBought;
        audioSource.Play();
    }

    public void ButtonClick()
    {
        audioSource.clip = buttonClick;
        audioSource.Play();
    }

    public void CoinAcquired()
    {
        audioSource.clip = coinAcquired;
        audioSource.Play();
    }
}
