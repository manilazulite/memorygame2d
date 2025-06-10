using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private BoardManager boardManager;

    [SerializeField] private Button generateGrid;
    [SerializeField] private TMP_InputField row_Input, column_Input;

    public GridLayoutGroup BoardLayout;

    [SerializeField] private TextMeshProUGUI warningMsg;

    [SerializeField] private GameObject menuPanel;

    public int Total = 0;

    private void Awake()
    {
        instance = this;
        Initialize();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Initialize()
    {
        generateGrid.onClick.AddListener(CheckIfGridIsValid);
        boardManager = FindFirstObjectByType<BoardManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckIfGridIsValid()
    {
        Total = int.Parse(row_Input.text) * int.Parse(column_Input.text);
        Debug.Log("total : " + Total);

        bool cangenerate = (Total % 2 == 0) ? true : false;

        if(cangenerate)
        {
            warningMsg.text = "Valid Combination";
            menuPanel.SetActive(false);

            if (BoardLayout.constraint == GridLayoutGroup.Constraint.FixedColumnCount)
            {
                BoardLayout.constraintCount = int.Parse(row_Input.text);
            }
            else
            {
                BoardLayout.constraintCount = int.Parse(row_Input.text);
            }

            boardManager.GenerateGrid();
        }
        else
        {
            warningMsg.text = "Invalid Combination";
        }
    }

    
}
 