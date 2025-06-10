using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button generateGrid;
    [SerializeField] private TMP_InputField row_Input, column_Input;

    [SerializeField] private TextMeshProUGUI warningMsg;

    [SerializeField] private GameObject menuPanel;

    private void Awake()
    {
        Initialize();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Initialize()
    {
        generateGrid.onClick.AddListener(CheckIfGridIsValid);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckIfGridIsValid()
    {
        int total = int.Parse(row_Input.text) * int.Parse(column_Input.text);

        bool cangenerate = (total % 2 == 0) ? true : false;

        if(cangenerate)
        {
            warningMsg.text = "Valid Combination";
            menuPanel.SetActive(false);
            Invoke("GenerateGrid", 1f);
        }
        else
        {
            warningMsg.text = "Invalid Combination";
        }
    }

    private void GenerateGrid()
    {
        //Create the cards
    }
}
 