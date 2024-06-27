using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FormulaController : MonoBehaviour
{
    public TextMeshProUGUI[] formulaTexts;
    private string sceneName;

    // ilk 5 tanesi ilk level sonraki 5 ikinci level ve son 5 üçüncü level için
    private string[] formulas = { "NaCl", "H2O", "NH3", "O2", "CH4", "HCl", "CO2", "N2", "H2SO4", "CaCO3", "NaOH", "KNO3", "HNO3", "C2H5OH", "C6H12O6" };

    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Tile1Game")
        {
            SetFormulas(0);
        }
        else if(sceneName == "Tile2Game")
        {
            SetFormulas(5);
        }
        else if(sceneName == "Tile3Game")
        {
            SetFormulas(10);
        }
       
    }

    void SetFormulas(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            formulaTexts[i].text = formulas[i + index];
        }
    }
}
