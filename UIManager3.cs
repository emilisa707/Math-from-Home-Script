using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager3 : MonoBehaviour
{
    GameData gamedata;
    public Button unlockMenyusunAngka01Button;
    public Button unlockMenyusunAngka02Button;
    public Button unlockMenyusunAngka03Button;
    public Button unlockMenyusunAngka04Button;


    // Start is called before the first frame update
    private void Start()
    {
        gamedata = FindObjectOfType<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamedata.unlockMenyusunAngka01 && unlockMenyusunAngka01Button != null)
        {
            unlockMenyusunAngka01Button.enabled = true;
            unlockMenyusunAngka01Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenyusunAngka01Button.enabled = false;
            unlockMenyusunAngka01Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenyusunAngka02 && unlockMenyusunAngka02Button != null)
        {
            unlockMenyusunAngka02Button.enabled = true;
            unlockMenyusunAngka02Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenyusunAngka02Button.enabled = false;
            unlockMenyusunAngka02Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenyusunAngka03 && unlockMenyusunAngka03Button != null)
        {
            unlockMenyusunAngka03Button.enabled = true;
            unlockMenyusunAngka03Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenyusunAngka03Button.enabled = false;
            unlockMenyusunAngka03Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenyusunAngka04 && unlockMenyusunAngka04Button != null)
        {
            unlockMenyusunAngka04Button.enabled = true;
            unlockMenyusunAngka04Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenyusunAngka04Button.enabled = false;
            unlockMenyusunAngka04Button.GetComponent<Image>().color = Color.gray;
        }
    }
}