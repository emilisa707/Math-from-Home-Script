using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenghitungAngka : MonoBehaviour
{
    GameManager gameManager;
    protected GameData gamedata;
    protected int activeScene;

    public int score;
    public int minRange, maxRange;
    public int SoalKe = 0;
    public int jumlahAngkaKiri;
    public int jumlahAngkaKanan;
    public int jumlahAngka;

    public Vector2 offset;
    public Vector2 startPos;

    public GameObject tilePrefab;
    public GameObject spritePrefab;
    public GameObject rightObject;

    public Sprite[] spriteObjects;

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
        gamedata = FindObjectOfType<GameData>();

        CreateLeftTile();
        CreateRightTile();
        SoalKe += 1;
        RandomAngka();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateLeftTile()
    {
        offset = new Vector2(1.5f, 1.5f);
        gameManager.soalKeUI.text = SoalKe + " / 10";
        jumlahAngkaKiri = Random.Range(minRange, maxRange);
        int index = Random.Range(0, spriteObjects.Length);
        Debug.Log(index);
        Debug.Log("jumlahAngka = " + jumlahAngkaKiri);

        if (jumlahAngkaKiri == 0)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = transform.position + (Vector3.left * (offset.x * jumlahAngkaKiri / 2)) + (Vector3.down);
            Vector2 pos = new Vector3(startPos.x + (-1), startPos.y + offset.y);
            InstantiateLeftBackground(pos, 0, index);
        }
        else if (jumlahAngkaKiri < 6 && jumlahAngkaKiri > 0)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = transform.position + (Vector3.left * (offset.x * jumlahAngkaKiri / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngkaKiri; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateLeftBackground(pos, x, index);
            }
        }

        else if (jumlahAngkaKiri < 11 && jumlahAngkaKiri > 5)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = transform.position + (Vector3.left * (offset.x * 5 / 2)) + (Vector3.down);
            for (int x = 0; x < 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateLeftBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngkaKiri - 5) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngkaKiri - 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateLeftBackground(pos, x, index);
            }
        }
    }

    void CreateRightTile()
    {
        offset = new Vector2(1.5f, 1.5f);
        gameManager.soalKeUI.text = SoalKe + " / 10";
        jumlahAngkaKanan = Random.Range(minRange, maxRange);
        int index = Random.Range(0, spriteObjects.Length);
        Debug.Log(index);
        Debug.Log("jumlahAngka = " + jumlahAngkaKanan);

        if (jumlahAngkaKanan == 0)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = rightObject.transform.position + (Vector3.left * (offset.x * jumlahAngkaKanan / 2)) + (Vector3.down);
            Vector2 pos = new Vector3(startPos.x + (-1), startPos.y + offset.y);
            InstantiateRightBackground(pos, 0, index);
        }
        else if (jumlahAngkaKanan < 6 && jumlahAngkaKanan > 0)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = rightObject.transform.position + (Vector3.left * (offset.x * jumlahAngkaKanan / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngkaKanan; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateRightBackground(pos, x, index);
            }
        }

        else if (jumlahAngkaKanan < 11 && jumlahAngkaKanan > 5)
        {
            offset = new Vector2(1.5f, 1.5f);
            startPos = rightObject.transform.position + (Vector3.left * (offset.x * 5 / 2)) + (Vector3.down);
            for (int x = 0; x < 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateRightBackground(pos, x, index);
            }

            startPos = rightObject.transform.position + (Vector3.left * (offset.x* (jumlahAngkaKanan - 5) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngkaKanan - 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateRightBackground(pos, x, index);
            }
        }
    }

    private void InstantiateLeftBackground(Vector2 pos, int x, int index)
    {
        if (jumlahAngkaKiri < 21)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.parent = transform;
            gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";
            if (jumlahAngkaKiri != 0)
            {
                GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
                gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                gameObject.tag = "icon";
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
            }
        }

    }

    private void InstantiateRightBackground(Vector2 pos, int x, int index)
    {
        if (jumlahAngkaKanan < 21)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.parent = rightObject.transform;
            gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";
            if (jumlahAngkaKanan != 0)
            {
                GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
                gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                gameObject.tag = "icon";
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
            }
        }

    }

    void RandomAngka()
    {
        jumlahAngka = jumlahAngkaKanan + jumlahAngkaKiri;

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
            gameManager.scoreTextGame.text = "" + score;

            if (score == 10)
            {
                gameManager.scoreTextAkhir.text = "" + score;
                panelSelesai.SetActive(false);
                panelSelanjutnya.SetActive(true);
                UnlockNextLevel();
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
            if (score == 10)
            {
                gameManager.scoreTextAkhir.text = "" + score;
                panelSelesai.SetActive(false);
                panelSelanjutnya.SetActive(true);
            }
            else
            {
                panelSelesai.SetActive(true);
                gameManager.scoreTextAkhir.text = "" + score;

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
        CreateLeftTile();
        CreateRightTile();
        RandomAngka();
    }

    void UnlockNextLevel()
    {
        Debug.Log(activeScene);

        switch (activeScene)
        {
            case 17:
                gamedata.unlockMenghitungAngka02 = true;
                break;
            case 18:
                gamedata.unlockMenghitungAngka03 = true;
                break;

        }
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
