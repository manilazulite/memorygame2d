using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform gridParent;

    public List<Sprite> SpriteList = new List<Sprite>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        SpriteList = new List<Sprite>(Resources.LoadAll<Sprite>("texture"));
    }

    public void GenerateGrid()
    {
        Debug.Log("instantiating : "+ GameManager.instance.Total);
        //Create the cards
        for (int i = 0; i < GameManager.instance.Total; i++)
        {
            Debug.Log("instantiating : " + i);
            GameObject go = Instantiate(cardPrefab);
            go.transform.parent = gridParent;

            //Assign the texture to the image
            //go.GetComponent<CardController>().BackImage.sprite = AssignTextureToTheCard();
        }

        AssignTextureToTheCard();
    }

    private void AssignTextureToTheCard()
    {
        int limit = GameManager.instance.Total / 2;
        List<Sprite> templist = SpriteList;
        Debug.Log(templist.Count);

        int index = Random.Range(0, templist.Count - 1);
        Sprite sprite = templist[Random.Range(0, templist.Count - 1)];

        for (int i = 0; i < transform.childCount; i++)
        {
            gridParent.GetChild(i).GetComponent<CardController>().BackImage.GetComponent<Image>().sprite = sprite;
        }
        
        templist.RemoveAt(index);
    }
}
