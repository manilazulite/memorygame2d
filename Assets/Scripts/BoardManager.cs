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
        for (int i = 0; i < GameManager.instance.Total; i++)
        {
            GameObject go = Instantiate(cardPrefab);
            go.transform.parent = gridParent;
        }

        AssignTextureToTheCard();
    }


    private void AssignTextureToTheCard()
    {
        List<Sprite> templist = new List<Sprite>();
        int limit = GameManager.instance.Total / 2;
        templist = SpriteList;
        int tempindexsetter = 0;

        Sprite sprite;

        for (int i = 0; i < GameManager.instance.Total; i+=2)
        {
            int index = Random.Range(0, templist.Count - 1);
            sprite = templist[index];

            for (int j = i; j < i+2; j++)
            {
                gridParent.GetChild(j).name = j.ToString();
                gridParent.GetChild(j).GetComponent<CardController>().CardIndex = tempindexsetter;
                gridParent.GetChild(j).GetComponent<CardController>().BackImage.GetComponent<Image>().sprite = sprite;
                
            }

            tempindexsetter++;
            templist.RemoveAt(index);
        }

        ShuffleTheCards();
    }

    private void ShuffleTheCards()
    {
        for(int i = 0; i < gridParent.childCount; i++)
        {
            gridParent.GetChild(i).SetSiblingIndex(Random.Range(0, gridParent.childCount - 1));
        }
    }

    private void CompareCards()
    {

    }
}
