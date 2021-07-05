using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    TileManager tileManager;
    MenghitungAngka menghitungAngka;
    MenghitungAngkaLanjutan menghitungAngkaLanjutan;

    public Text scoreUI;
    public Text scoreTextGame;
    public Text scoreTextAkhir;
    public Text soalKeUI;

    public Text angkaPertama;
    public Text angkaKedua;
    public Text angkaKetiga;

    private void Start()
    {
        tileManager = FindObjectOfType<TileManager>();
        menghitungAngka = FindObjectOfType<MenghitungAngka>();
        menghitungAngkaLanjutan = FindObjectOfType<MenghitungAngkaLanjutan>();
    }

    public void TombolNol()
    {
        tileManager.Nilai(0);
    }

    public void TombolSatu()
    {
        tileManager.Nilai(1);
    }

    public void TombolDua()
    {
        tileManager.Nilai(2);
    }

    public void TombolTiga()
    {
        tileManager.Nilai(3);
    }

    public void TombolEmpat()
    {
        tileManager.Nilai(4);
    }

    public void TombolLima()
    {
        tileManager.Nilai(5);
    }

    public void TombolEnam()
    {
        tileManager.Nilai(6);
    }

    public void TombolTujuh()
    {
        tileManager.Nilai(7);
    }

    public void TombolDelapan()
    {
        tileManager.Nilai(8);
    }

    public void TombolSembilan()
    {
        tileManager.Nilai(9);
    }

    public void TombolSepuluh()
    {
        tileManager.Nilai(10);
    }

    public void TombolSebelas()
    {
        tileManager.Nilai(11);
    }

    public void TombolDuaBelas()
    {
        tileManager.Nilai(12);
    }

    public void TombolTigaBelas()
    {
        tileManager.Nilai(13);
    }

    public void TombolEmpatBelas()
    {
        tileManager.Nilai(14);
    }

    public void TombolLimaBelas()
    {
        tileManager.Nilai(15);
    }

    public void TombolEnamBelas()
    {
        tileManager.Nilai(16);
    }

    public void TombolTujuhBelas()
    {
        tileManager.Nilai(17);
    }

    public void TombolDelapanBelas()
    {
        tileManager.Nilai(18);
    }

    public void TombolSembilanBelas()
    {
        tileManager.Nilai(19);
    }

    public void TombolRestart()
    {
        SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void TombolSelanjutnya()
    {
        SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AngkaPertama(int angka)
    {
        if (angkaPertama != null)
        {
            angkaPertama.text = angka.ToString();
        }
    }

    public void AngkaKedua(int angka)
    {
        if (angkaKedua != null)
        {
            angkaKedua.text = angka.ToString();
        }
    }

    public void AngkaKetiga(int angka)
    {
        if (angkaKetiga != null)
        {
            angkaKetiga.text = angka.ToString();
        }
    }

    public void TombolPertama()
    {
        tileManager.Nilai(tileManager.randomNum[0]);
    }

    public void TombolKedua()
    {
        tileManager.Nilai(tileManager.randomNum[1]);
    }

    public void TombolKetiga()
    {
        tileManager.Nilai(tileManager.randomNum[2]);
    }

    public void TombolJawabanPertama()
    {
        menghitungAngka.Nilai(menghitungAngka.randomNum[0]);
    }

    public void TombolJawabanKedua()
    {
        menghitungAngka.Nilai(menghitungAngka.randomNum[1]);
    }

    public void TombolJawabanKetiga()
    {
        menghitungAngka.Nilai(menghitungAngka.randomNum[2]);
    }

    public void TombolJawaban1()
    {
        menghitungAngkaLanjutan.Nilai(menghitungAngkaLanjutan.randomNum[0]);
    }

    public void TombolJawaban2()
    {
        menghitungAngkaLanjutan.Nilai(menghitungAngkaLanjutan.randomNum[1]);
    }

    public void TombolJawaban3()
    {
        menghitungAngkaLanjutan.Nilai(menghitungAngkaLanjutan.randomNum[2]);
    }
}
