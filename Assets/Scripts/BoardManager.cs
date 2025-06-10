using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform gridParent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
    }
}
