
using UnityEngine;

public class MainMenuAnimations : MonoBehaviour
{
    [SerializeField] Animator mAnimation;
    
    public void MenuToSection1()
    {
        mAnimation.SetTrigger("PlayIsPressed");
    }

    public void Section1ToMenu()
    {
        mAnimation.SetTrigger("Section1ToMenu");
    }

    public void Section1ToSection2()
    {
        mAnimation.SetTrigger("Section1ToSection2");
    }
    

    public void Section2ToSection1()
    {
        mAnimation.SetTrigger("Section2ToSection1");
    }

    public void Section2ToSection3()
    {
        mAnimation.SetTrigger("Section2ToSection3");
    }

    public void Section3ToSection2()
    {
        mAnimation.SetTrigger("Section3ToSection2");
    }

    public void Section3ToSection4()
    {
        mAnimation.SetTrigger("Section3ToSection4");
    }

    public void Section4ToSection3()
    {
        mAnimation.SetTrigger("Section4ToSection3");
    }

    public void Section4ToSection5()
    {
        mAnimation.SetTrigger("Section4ToSection5");
    }

    public void Section5ToSection4()
    {
        mAnimation.SetTrigger("Section5ToSection4");
    }

    public void Section5ToSection6()
    {
        mAnimation.SetTrigger("Section5ToSection6");
    }

    public void Section6ToSection5()
    {
        mAnimation.SetTrigger("Section6ToSection5");
    }

    public void Section6ToSection7()
    {
        mAnimation.SetTrigger("Section6ToSection7");
    }

    public void Section7ToSection6()
    {
        mAnimation.SetTrigger("Section7ToSection6");
    }

    public void Section7ToSection8()
    {
        mAnimation.SetTrigger("Section7ToSection8");
    }

    public void Section8ToSection7()
    {
        mAnimation.SetTrigger("Section8ToSection7");
    }

    public void Section8ToSection9()
    {
        mAnimation.SetTrigger("Section8ToSection9");
    }

    public void Section9ToSection8()
    {
        mAnimation.SetTrigger("Section9ToSection8");
    }

    public void MainMenuToOptions()
    {
        mAnimation.SetTrigger("MainMenuToOptions");
    }

    public void MainMenuToShop()
    {
        mAnimation.SetTrigger("MainMenuToShop");
    }

    public void OptionsToMainMenu()
    {
        mAnimation.SetTrigger("OptionsToMainMenu");
    }

    public void ShopToMainMenu()
    {
        mAnimation.SetTrigger("ShopToMainMenu");
    }

    public void BasketballToARS()
    {
        mAnimation.SetTrigger("Basketball2ARS");
    }
    
    public void FootballToARS()
    {
        mAnimation.SetTrigger("Football2ARS");
    }
    
    public void BaseballToARS()
    {
        mAnimation.SetTrigger("Baseball2ARS");
    }
    
    public void TennisToARS()
    {
        mAnimation.SetTrigger("Tennis2ARS");
    }
    
    public void GolfToARS()
    {
        mAnimation.SetTrigger("Golf2ARS");
    }
    
    public void VolleyballToARS()
    {
        mAnimation.SetTrigger("Volleyball2ARS");
    }
    
    public void BilliardToARS()
    {
        mAnimation.SetTrigger("Billiard2ARS");
    }
    
    public void EightBallToARS()
    {
        mAnimation.SetTrigger("EightBall2ARS");
    }
    
    public void WheelchairToARS()
    {
        mAnimation.SetTrigger("Wheelchair2ARS");
    }
    
    public void BowlingToARS()
    {
        mAnimation.SetTrigger("Bowling2ARS");
    }
    
    public void AbstractToARS()
    {
        mAnimation.SetTrigger("Abstract2ARS");
    }
    
    public void ATVToARS()
    {
        mAnimation.SetTrigger("ATV2ARS");
    }
    
    public void CoronaToARS()
    {
        mAnimation.SetTrigger("Corona2ARS");
    }

    public void ARSButtonPress()
    {
        mAnimation.SetTrigger("ARSButtonPress");
    }

    public void Alright()
    {
        mAnimation.SetTrigger("Alright");
    }
}
