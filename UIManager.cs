using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    GameData gamedata;
    public Button unlockMengenalAngkaButton;
    public Button unlockMembandingkanAngkaButton;
    public Button unlockMenyusunAngkaButton;
    public Button unlockMenghitungAngkaButton;



    // Start is called before the first frame update
    private void Start()
    {
        gamedata = FindObjectOfType<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamedata.unlockMengenalAngka && unlockMengenalAngkaButton != null)
        {
            unlockMengenalAngkaButton.enabled = true;
            unlockMengenalAngkaButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMengenalAngkaButton.enabled = false;
            unlockMengenalAngkaButton.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMembandingkanAngka && unlockMembandingkanAngkaButton != null)
        {
            unlockMembandingkanAngkaButton.enabled = true;
            unlockMembandingkanAngkaButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            Debug.Log("ko ga ada lah");
            unlockMembandingkanAngkaButton.enabled = false;
            unlockMembandingkanAngkaButton.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenyusunAngka && unlockMenyusunAngkaButton != null)
        {
            unlockMenyusunAngkaButton.enabled = true ;
            unlockMenyusunAngkaButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenyusunAngkaButton.enabled = false;
            unlockMenyusunAngkaButton.GetComponent<Image>().color = Color.gray;
        }

        if (gamedata.unlockMenghitungAngka && unlockMenghitungAngkaButton != null)
        {
            unlockMenghitungAngkaButton.enabled = true;
            unlockMenghitungAngkaButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            unlockMenghitungAngkaButton.enabled = false;
            unlockMenghitungAngkaButton.GetComponent<Image>().color = Color.gray;
        }
    }
}
