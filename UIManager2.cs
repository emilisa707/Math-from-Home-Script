using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    GameData gamedata;
    public Button unlockMembandingkanAngka01Button;
    public Button unlockMembandingkanAngka02Button;
    public Button unlockMembandingkanAngka03Button;
    public Button unlockMembandingkanAngka04Button;

    private void Start()
    {
        gamedata = FindObjectOfType<GameData>();
    }
    void Update()
    {
        if (gamedata.unlockMembandingkanAngka01 && unlockMembandingkanAngka01Button != null)
        {
            unlockMembandingkanAngka01Button.enabled = true;
            unlockMembandingkanAngka01Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMembandingkanAngka01Button.enabled = false;
            unlockMembandingkanAngka01Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMembandingkanAngka02 && unlockMembandingkanAngka01Button != null)
        {
            unlockMembandingkanAngka02Button.enabled = true;
            unlockMembandingkanAngka02Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMembandingkanAngka02Button.enabled = false;
            unlockMembandingkanAngka02Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMembandingkanAngka03 && unlockMembandingkanAngka03Button != null)
        {
            unlockMembandingkanAngka03Button.enabled = true;
            unlockMembandingkanAngka03Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMembandingkanAngka03Button.enabled = false;
            unlockMembandingkanAngka03Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMembandingkanAngka04 && unlockMembandingkanAngka04Button != null)
        {
            unlockMembandingkanAngka04Button.enabled = true;
            unlockMembandingkanAngka04Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMembandingkanAngka04Button.enabled = false;
            unlockMembandingkanAngka04Button.GetComponent<Image>().color = Color.gray;
        }
    }
}