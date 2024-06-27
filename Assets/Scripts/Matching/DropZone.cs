using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour
{
    public string correctFormula;
    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioSource audioSource;
    public static bool isGameOver;
    public static List<GameObject> droppedObjects = new List<GameObject>();

    private void Start() {
        droppedObjects.Clear();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(IsCorrectMatch(other))
        {
            audioSource.PlayOneShot(correctSound);
            droppedObjects.Add(other.gameObject);
            Destroy(other.gameObject);
            Debug.Log("Correct match!");
        }
        else{
            isGameOver = true;
            audioSource.PlayOneShot(wrongSound);
            Debug.Log("Wrong match!");
        }
    }

    private bool IsCorrectMatch(Collider2D other)
    {
        // Level1
        if (other.gameObject.CompareTag("Su") && correctFormula.Equals("H2O"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Tuz") && correctFormula.Equals("NaCl"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Metan") && correctFormula.Equals("CH4"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Amonyak") && correctFormula.Equals("NH3"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Oksijen") && correctFormula.Equals("O2"))
        {
            return true;
        }
        // Level2
        if (other.gameObject.CompareTag("HidroklorikAsit") && correctFormula.Equals("HCl"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("KarbonDioksit") && correctFormula.Equals("CO2"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Azot") && correctFormula.Equals("N2"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("SulfurikAsit") && correctFormula.Equals("H2SO4"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("KalsiyumKarbonat") && correctFormula.Equals("CaCO3"))
        {
            return true;
        }

        // Level3
        if (other.gameObject.CompareTag("SodyumHidroksit") && correctFormula.Equals("NaOH"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("PotasyumNitrat") && correctFormula.Equals("KNO3"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("NitrikAsit") && correctFormula.Equals("HNO3"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Etanol") && correctFormula.Equals("C2H5OH"))
        {
            return true;
        }
        else if(other.gameObject.CompareTag("Glukoz") && correctFormula.Equals("C6H12O6"))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
