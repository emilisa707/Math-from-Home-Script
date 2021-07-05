using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager4 : MonoBehaviour
{
    GameData gamedata;
    public Button unlockMenghitungAngka01Button;
    public Button unlockMenghitungAngka02Button;
    public Button unlockMenghitungAngka03Button;



    // Start is called before the first frame update

    private void Start()
    {
        gamedata = FindObjectOfType<GameData>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gamedata.unlockMenghitungAngka01 && unlockMenghitungAngka01Button != null)
        {
            unlockMenghitungAngka01Button.enabled = true;
            unlockMenghitungAngka01Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenghitungAngka01Button.enabled = false;
            unlockMenghitungAngka01Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenghitungAngka02 && unlockMenghitungAngka02Button != null)
        {
            unlockMenghitungAngka02Button.enabled = true;
            unlockMenghitungAngka02Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenghitungAngka02Button.enabled = false;
            unlockMenghitungAngka02Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenghitungAngka03 && unlockMenghitungAngka03Button != null)
        {
            unlockMenghitungAngka03Button.enabled = true;
            unlockMenghitungAngka03Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenghitungAngka03Button.enabled = false;
            unlockMenghitungAngka03Button.GetComponent<Image>().color = Color.gray;
        }
    }
}