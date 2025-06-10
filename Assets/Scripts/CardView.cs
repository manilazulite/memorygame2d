using UnityEngine;
using UnityEngine.UI;   

public class CardView : MonoBehaviour
{
    public Image FrontImage;
    public GameObject CardBack;

    public void SetCardImage(Sprite frontimg)
    {
        FrontImage.sprite = frontimg;
    }

    public void Hide()
    {

    }

    public void Reveal()
    {

    }
}
