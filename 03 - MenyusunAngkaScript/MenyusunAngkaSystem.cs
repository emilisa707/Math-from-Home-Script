using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MenyusunAngkaSystem : MonoBehaviour
{
    GameData gamedata;
    GameManager gameManager;
    protected int activeScene;
    public UnityEvent jawabanBenar, jawabanSalah;
    public GameObject kotak1, kotak2, kotak3;
    public GameObject kamuBenar;
    public GameObject andaSalah;
    public GameObject panelSelesai;
    public GameObject panelSelanjutnya;

    public bool gameSelesai;

    public int score;
    public int SoalKe = 0;
    public int jumlahAngka;

    public int minAngka, maxAngka;
    public int[] randomNomor = new int[3];

    public Text nomorPertama, nomorKedua, nomorKetiga;
    public Vector2 pos1, pos2, pos3;

    public int nomor1, nomor2, nomor3;
    public bool status1, status2, status3;
    public bool statusComplete;
    // Start is called before the first frame update
    void Start()
    {
        activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        gamedata = FindObjectOfType<GameData>();
        gameSelesai = false;
        gameManager = FindObjectOfType<GameManager>();
        pos1 = nomorPertama.gameObject.transform.localPosition;
        pos2 = nomorKedua.gameObject.transform.localPosition;
        pos3 = nomorKetiga.gameObject.transform.localPosition;
        RandomNilai();   
    }

    // Update is called once per frame
    void Update()
    {
        if(status1 && status2 && status3 && !statusComplete)
        {
            statusComplete = true;

            if (nomor1 < nomor2 && nomor2 < nomor3)
            {
                score += 1;
                AndaBenar();
            }
            else
            {
                AndaSalah();
            }


        }
    }

    void RandomNilai()
    {
        randomNomor[0] = Random.Range(minAngka, maxAngka);
        randomNomor[1] = Random.Range(minAngka, maxAngka);
        randomNomor[2] = Random.Range(minAngka, maxAngka);

        int ITERATION = 0;
        while (randomNomor[0] == randomNomor[1] || randomNomor[0] == randomNomor[2] || randomNomor[1] == randomNomor[2])
        {
            randomNomor[0] = Random.Range(minAngka, maxAngka);
            randomNomor[1] = Random.Range(minAngka, maxAngka);
            randomNomor[2] = Random.Range(minAngka, maxAngka);

            ITERATION++;
        }
        ITERATION = 0;

        SoalKe += 1;
        gameManager.scoreUI.text = "" + score;
        gameManager.soalKeUI.text = "" + SoalKe + "/10";

        nomorPertama.text = "" + randomNomor[0];
        nomorKedua.text = "" + randomNomor[1];
        nomorKetiga.text = "" + randomNomor[2];
    }

    public void NomorPertama(int nomor)
    {
        nomor1 = nomor;
        status1 = true;
    }

    public void NomorKedua(int nomor)
    {
        nomor2 = nomor;
        status2 = true;
    }

    public void NomorKetiga(int nomor)
    {
        nomor3 = nomor;
        status3 = true;
    }

    void AndaBenar()
    {
        jawabanBenar.Invoke();
        if (SoalKe == 10 && !gameSelesai)
        {
            gameSelesai = true;
            if (score == 10)
            {
                panelSelanjutnya.SetActive(true);
                gameManager.scoreTextAkhir.text = "" + score;
                UnlockLevel();
            }
            else
            {
                panelSelesai.SetActive(true);
                gameManager.scoreTextGame.text = "" + score;
            }
        }
        else
        {
            kamuBenar.SetActive(true);
            StartCoroutine(DisableImage());
        }
    }

    void AndaSalah()
    {
        if (SoalKe == 10 && !gameSelesai)
        {
            gameSelesai = true;
            if (score == 10)
            {
                panelSelanjutnya.SetActive(true);
                gameManager.scoreTextAkhir.text = "" + score;
                UnlockLevel();
            }
            else
            {
                panelSelesai.SetActive(true);
                gameManager.scoreTextGame.text = "" + score;
            }
        }
        else
        {
            andaSalah.SetActive(true);
            jawabanSalah.Invoke();
            StartCoroutine(DisableImage());
        }
    }

    IEnumerator DisableImage()
    {
        yield return new WaitForSeconds(1.5f);
        andaSalah.SetActive(false);
        kamuBenar.SetActive(false);
        statusComplete = false;
        status1 = false;
        status2 = false;
        status3 = false;
        

        CreateTile();
    }

    void CreateTile()
    {
        nomorPertama.gameObject.transform.localPosition = pos1;
        nomorPertama.gameObject.GetComponent<MovingSystem>().enabled = true;
        kotak1.gameObject.GetComponent<Collider2D>().enabled = true;
        nomorKedua.gameObject.transform.localPosition = pos2;
        nomorKedua.gameObject.GetComponent<MovingSystem>().enabled = true;
        kotak2.gameObject.GetComponent<Collider2D>().enabled = true;
        nomorKetiga.gameObject.transform.localPosition = pos3;
        nomorKetiga.gameObject.GetComponent<MovingSystem>().enabled = true;
        kotak3.gameObject.GetComponent<Collider2D>().enabled = true;

        RandomNilai();
    }

    void UnlockLevel()
    {
        switch (activeScene)
        {
            case 12:
                gamedata.unlockMenyusunAngka02 = true;
                break;
            case 13:
                gamedata.unlockMenyusunAngka03 = true;
                break;
            case 14:
                gamedata.unlockMenyusunAngka04 = true;
                break;
            case 15:
                gamedata.unlockMenghitungAngka = true;
                gamedata.unlockMenghitungAngka01 = true;
                break;

        }
    }
}
