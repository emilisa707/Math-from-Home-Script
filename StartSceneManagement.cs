using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManagement : MonoBehaviour
{
    public void MengenalAngka()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MengenalAngka");
    }
    public void MengenalAngkaLevelSatu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MengenalAngka01");
    }

    public void MengenalAngkaLevelDua()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MengenalAngka02");
    }

    public void MengenalAngkaLevelTiga()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MengenalAngka03");
    }

    public void MengenalAngkaLevelEmpat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MengenalAngka04");
    }

    public void MenyusunAngka()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenyusunAngka");
    }
    public void MenyusunAngkaLevelSatu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenyusunAngka01");
    }

    public void MenyusunAngkaLevelDua()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenyusunAngka02");
    }
    public void MenyusunAngkaLevelTiga()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenyusunAngka03");
    }

    public void MenyusunAngkaLevelEmpat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menyusunAngka04");
    }

    public void MembandingkanAngka()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MembandingkanAngka");
    }
    public void MembandingkanAngkaLevelSatu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MembandingkanAngka01");
    }
    public void MembandingkanAngkaLevelDua()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MembandingkanAngka02");
    }
    public void MembandingkanAngkaLevelTiga()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MembandingkanAngka03");
    }

    public void MembandingkanAngkaLevelEmpat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MembandingkanAngka04");
    }

    public void MengHitungAngka()
    {
        SceneManager.LoadScene("MenghitungAngka");
    }

    public void MengHitungAngkaLevelSatu()
    {
        SceneManager.LoadScene("MenghitungAngka01");
    }

    public void MengHitungAngkaLevelDua()
    {
        SceneManager.LoadScene("MenghitungAngka02");
    }

    public void MengHitungAngkaLevelTiga()
    {
        SceneManager.LoadScene("MenghitungAngka03");
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
