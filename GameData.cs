using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class GameData : MonoBehaviour
{

    private static GameData playerInstance;//biar gak duplikat datanya

    public static GameData PlayerInstance
    {
        get { return playerInstance; }
    }

    public bool alreadyPlay = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }
    private void Start()
    {
        string path = Application.persistentDataPath + "/saveFile.dat";
        if (File.Exists(path))
        {
            GameStateData data = Game.LoadPlayer();

            unlockMengenalAngka = data.unlockMengenalAngka;
            unlockMengenalAngka01 = data.unlockMengenalAngka01;
            unlockMengenalAngka02 = data.unlockMengenalAngka02;
            unlockMengenalAngka03 = data.unlockMengenalAngka03;
            unlockMengenalAngka04 = data.unlockMengenalAngka04;

            unlockMembandingkanAngka = data.unlockMembandingkanAngka;
            unlockMembandingkanAngka01 = data.unlockMembandingkanAngka01;
            unlockMembandingkanAngka02 = data.unlockMembandingkanAngka02;
            unlockMembandingkanAngka03 = data.unlockMembandingkanAngka03;
            unlockMembandingkanAngka04 = data.unlockMembandingkanAngka04;

            unlockMenyusunAngka = data.unlockMenyusunAngka;
            unlockMenyusunAngka01 = data.unlockMenyusunAngka01;
            unlockMenyusunAngka02 = data.unlockMenyusunAngka02;
            unlockMenyusunAngka03 = data.unlockMenyusunAngka03;
            unlockMenyusunAngka04 = data.unlockMenyusunAngka04;

            unlockMenghitungAngka = data.unlockMenghitungAngka;
            unlockMenghitungAngka01 = data.unlockMenghitungAngka01;
            unlockMenghitungAngka02 = data.unlockMenghitungAngka02;
            unlockMenghitungAngka03 = data.unlockMenghitungAngka03;
        }
        else
        {
            unlockMengenalAngka = true;
            unlockMengenalAngka01 = true;
            unlockMengenalAngka02 = false;
            unlockMengenalAngka03 = false;
            unlockMengenalAngka04 = false;

            unlockMembandingkanAngka = true;
            unlockMembandingkanAngka01 = true;
            unlockMembandingkanAngka02 = false;
            unlockMembandingkanAngka03 = false;
            unlockMembandingkanAngka04 = false;

            unlockMenyusunAngka = true;
            unlockMenyusunAngka01 = true;
            unlockMenyusunAngka02 = false;
            unlockMenyusunAngka03 = false;
            unlockMenyusunAngka04 = false;

            unlockMenghitungAngka = true;
            unlockMenghitungAngka01 = true;
            unlockMenghitungAngka02 = false;
            unlockMenghitungAngka03 = false;

        }

    }

    private void OnApplicationQuit()
    {
        Game.SavePlayer(this);
    }

    private void OnApplicationPause(bool pause)
    {
        Game.SavePlayer(this);
    }
    public bool unlockMengenalAngka;
    public bool unlockMengenalAngka01;
    public bool unlockMengenalAngka02;
    public bool unlockMengenalAngka03;
    public bool unlockMengenalAngka04;

    public bool unlockMembandingkanAngka;
    public bool unlockMembandingkanAngka01;
    public bool unlockMembandingkanAngka02;
    public bool unlockMembandingkanAngka03;
    public bool unlockMembandingkanAngka04;

    public bool unlockMenyusunAngka;
    public bool unlockMenyusunAngka01;
    public bool unlockMenyusunAngka02;
    public bool unlockMenyusunAngka03;
    public bool unlockMenyusunAngka04;

    public bool unlockMenghitungAngka;
    public bool unlockMenghitungAngka01;
    public bool unlockMenghitungAngka02;
    public bool unlockMenghitungAngka03;

}