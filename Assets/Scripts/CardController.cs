using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class CardController : MonoBehaviour, IPointerClickHandler
{
    private CardData data;
    private CardView view;

    public GameObject BackImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    /// <summary>
    /// rotate the card no clicked
    /// rotation value is supplied from the inspector
    /// this method is called from the button event of the front and back images 
    /// </summary>
    /// <param name="rotval"></param>
    public void RevealOrHide(int rotval)
    {
        transform.DORotate(new Vector3(0, rotval, 0), 0.25f, RotateMode.Fast);
    }




}
