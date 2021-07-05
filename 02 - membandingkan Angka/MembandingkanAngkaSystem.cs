using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MembandingkanAngkaSystem : MonoBehaviour
{
    //TileManager tileManager;
    public UnityEvent jawabanBenar, jawabanSalah;
    GameData gamedata;

    protected int activeScene;
    public GameObject kamuBenar;
    public GameObject kamuSalah;
    public GameObject stageSelesai;
    public GameObject stageSelanjutnya;

    public GameObject kotakSamaDengan;
    public GameObject kotakLebihKecil;
    public GameObject kotakLebihBesar;

    ComparingBoxSystem comparingBoxSystem;
    GameManager gameManager;
    public int minNumber, maxNumber;
    public int[] randomNomor = new int[2];

    public Text nomorKanan, nomorKiri;
    Vector2 pos1, pos2, pos3;

    int soalKe;
    public int skor;
    public int totalSkor;
    public bool benar;

    // Start is called before the first frame update
    void Start()
    {
        comparingBoxSystem = FindObjectOfType<ComparingBoxSystem>();
        gameManager = FindObjectOfType<GameManager>();
        activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        gamedata = FindObjectOfType<GameData>();

        pos1 = kotakSamaDengan.gameObject.transform.position;
        pos2 = kotakLebihBesar.gameObject.transform.position;
        pos3 = kotakLebihKecil.gameObject.transform.position;

        CreateTile();
    }

    // Update is called once per frame

    void RandomNumber()
    {
        randomNomor[0] = Random.Range(minNumber, maxNumber);
        randomNomor[1] = Random.Range(minNumber, maxNumber);

        nomorKiri.text = "" + randomNomor[0];
        nomorKanan.text = "" + randomNomor[1];

        comparingBoxSystem.angkaKiri = randomNomor[0];
        comparingBoxSystem.angkaKanan = randomNomor[1];
    }

    public void KamuBenar()
    {
        jawabanBenar.Invoke();
        StartCoroutine(UnableImageBenar());
    }

    public void KamuSalah()
    {
        jawabanSalah.Invoke();
        StartCoroutine(UnableImageSalah());
    }

    IEnumerator DisableImage()
    {
        yield return new WaitForSeconds(1.5f);
        kamuSalah.SetActive(false);
        kamuBenar.SetActive(false);
        benar = false;

        CreateTile();
    }

    IEnumerator UnableImageBenar()
    {
        yield return new WaitForSeconds(0.5f);

        if (soalKe == 10)
        {
            if (skor == 10)
            {
                gameManager.scoreTextAkhir.text = "" + skor;
                stageSelesai.SetActive(false);
                stageSelanjutnya.SetActive(true);
                UnlockLevel();
            }
            else
            {
                stageSelesai.SetActive(true);
                gameManager.scoreTextGame.text = "" + skor;
            }
        }
        else
        {
            gameManager.scoreUI.text = "" + skor;
            kamuBenar.SetActive(true);
            StartCoroutine(DisableImage());
        }
    }

    IEnumerator UnableImageSalah()
    {
        yield return new WaitForSeconds(0.5f);
        if (soalKe == 10)
        {
            if (skor == 10)
            {
                gameManager.scoreTextAkhir.text = "" + skor;
                stageSelesai.SetActive(false);
                stageSelanjutnya.SetActive(true);
                UnlockLevel();
            }
            else
            {
                stageSelesai.SetActive(true);
                gameManager.scoreTextGame.text = "" + skor;
            }
        }
        else
        {
            gameManager.scoreUI.text = "" + skor;
            kamuSalah.SetActive(true);
            StartCoroutine(DisableImage());
        }
    }
    void CreateTile()
    {
        soalKe += 1;
        gameManager.soalKeUI.text = soalKe + "/10";

        kotakSamaDengan.gameObject.transform.position = pos1;
        kotakSamaDengan.gameObject.GetComponent<MovingSystem>().enabled = true;

        kotakLebihBesar.gameObject.transform.position = pos2;
        kotakLebihBesar.gameObject.GetComponent<MovingSystem>().enabled = true;

        kotakLebihKecil.gameObject.transform.position = pos3;
        kotakLebihKecil.gameObject.GetComponent<MovingSystem>().enabled = true;

        RandomNumber();
    }

    public void UnlockLevel()
    {
        switch (activeScene)
        {
            case 7:
                gamedata.unlockMembandingkanAngka02 = true;
                break;
            case 8:
                gamedata.unlockMembandingkanAngka03 = true;
                break;
            case 9:
                gamedata.unlockMembandingkanAngka04 = true;
                break;
            case 10:
                gamedata.unlockMenyusunAngka = true;
                gamedata.unlockMenyusunAngka01 = true;
                break;

        }
    }
}
