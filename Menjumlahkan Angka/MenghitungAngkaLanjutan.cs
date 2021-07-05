using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenghitungAngkaLanjutan : MonoBehaviour
{
    GameManager gameManager;
    protected GameData gamedata;
    protected int activeScene;

    public int score;
    public int minRange, maxRange;
    public int SoalKe = 0;
    public int[] randomNomor = new int[2];
    public int jumlahAngka;

    public Vector2 offset;
    public Vector2 startPos;

    public Text teksKiri;
    public Text teksKanan;


    public UnityEvent jawabanBenar, jawabanSalah;
    public GameObject kamuBenar, kamuSalah;
    public bool gameSelesai;
    public GameObject panelSelesai;
    public GameObject panelSelanjutnya;

    public int[] randomNum = new int[3];
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;

        SoalKe += 1;
        RandomNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomNumber()
    {
        randomNomor[0] = Random.Range(minRange, maxRange);
        randomNomor[1] = Random.Range(minRange, maxRange);

        teksKiri.text = "" + randomNomor[0];
        teksKanan.text = "" + randomNomor[1];

        RandomAngka();
    }

    void RandomAngka()
    {
        jumlahAngka = randomNomor[0] + randomNomor[1];

        randomNum[0] = Random.Range(minRange, maxRange);
        randomNum[1] = Random.Range(minRange, maxRange);
        randomNum[2] = Random.Range(minRange, maxRange);

        int indexSlot = Random.Range(0, randomNum.Length);
        randomNum[indexSlot] = jumlahAngka;
        Debug.Log("" + indexSlot);

        int ITERATION = 0;
        while (randomNum[0] == randomNum[1] || randomNum[0] == randomNum[2] || randomNum[1] == randomNum[2])
        {
            randomNum[0] = Random.Range(minRange, maxRange);
            randomNum[1] = Random.Range(minRange, maxRange);
            randomNum[2] = Random.Range(minRange, maxRange);

            indexSlot = Random.Range(0, randomNum.Length);
            Debug.Log("" + indexSlot);
            randomNum[indexSlot] = jumlahAngka;
            ITERATION++;
        }
        ITERATION = 0;
        Debug.Log(randomNum[0] + " " + randomNum[1] + " " + randomNum[2]);

        gameManager.AngkaPertama(randomNum[0]);
        gameManager.AngkaKedua(randomNum[1]);
        gameManager.AngkaKetiga(randomNum[2]);
    }

    public void Nilai(int nilai)
    {
        if (nilai == jumlahAngka)
        {
            score += 1;
            gameManager.scoreUI.text = "" + score;
            jawabanBenar.Invoke();
            CheckNilaiBenar();
        }
        else
        {
            jawabanSalah.Invoke();
            CheckNilaiSalah();
        }
    }

    void CheckNilaiBenar()
    {
        if (SoalKe == 10 && !gameSelesai)
        {
            gameSelesai = true;
            panelSelesai.SetActive(true);
            gameManager.scoreTextAkhir.text = "" + score;

            if (score == 10)
            {
                panelSelesai.SetActive(false);
                panelSelanjutnya.SetActive(true);
            }
        }
        else
        {
            kamuBenar.SetActive(true);
            StartCoroutine(DisableImage());
        }
    }

    void CheckNilaiSalah()
    {
        if (SoalKe == 10 && !gameSelesai)
        {
            gameSelesai = true;
            panelSelesai.SetActive(true);
            gameManager.scoreTextAkhir.text = "" + score;

            if (score == 10)
            {
                panelSelesai.SetActive(false);
                panelSelanjutnya.SetActive(true);
            }
        }
        else
        {
            kamuSalah.SetActive(true);
            StartCoroutine(DisableImage());
        }
    }

    IEnumerator DisableImage()
    {
        yield return new WaitForSeconds(1.5f);
        kamuSalah.SetActive(false);
        kamuBenar.SetActive(false);

        DestroyAll("tile");
        DestroyAll("icon");

        SoalKe += 1;
        RandomNumber();
        RandomAngka();
    }

    void DestroyAll(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
