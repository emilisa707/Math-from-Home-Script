using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager1 : MonoBehaviour
{
    GameData gamedata;
    public Button unlockMengenalAngka01Button;
    public Button unlockMengenalAngka02Button;
    public Button unlockMengenalAngka03Button;
    public Button unlockMengenalAngka04Button;

    private void Start()
    {
        gamedata = FindObjectOfType<GameData>();
    }
    void Update()
    {
        if (gamedata.unlockMengenalAngka01 && unlockMengenalAngka01Button != null)
        {
            unlockMengenalAngka01Button.enabled = true;
            unlockMengenalAngka01Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMengenalAngka01Button.enabled = false;
            unlockMengenalAngka01Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMengenalAngka02 && unlockMengenalAngka02Button != null)
        {
            unlockMengenalAngka02Button.enabled = true;
            unlockMengenalAngka02Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMengenalAngka02Button.enabled = false;
            unlockMengenalAngka02Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMengenalAngka03 && unlockMengenalAngka03Button != null)
        {
            unlockMengenalAngka03Button.enabled = true;
            unlockMengenalAngka03Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMengenalAngka03Button.enabled = false;
            unlockMengenalAngka03Button.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMengenalAngka04 && unlockMengenalAngka04Button != null)
        {
            unlockMengenalAngka04Button.enabled = true;
            unlockMengenalAngka04Button.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMengenalAngka04Button.enabled = false;
            unlockMengenalAngka04Button.GetComponent<Image>().color = Color.gray;
        }
    }
}