using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TileManager : MonoBehaviour
{
    GameManager gameManager;
    protected GameData gamedata;

    protected int activeScene;
    public int score;
    public int minRange, maxRange;
    public int SoalKe = 0;
    public int jumlahAngka;
    public Vector2 offset;
    public Vector2 startPos;

    public GameObject tilePrefab;
    public GameObject spritePrefab;
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
        gamedata = FindObjectOfType<GameData>();
        activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        CreateTile();
    }

    void CreateTile()
    {
        offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
        SoalKe += 1;
        gameManager.soalKeUI.text = SoalKe + " / 10";
        jumlahAngka = Random.Range(minRange, maxRange);
        int index = Random.Range(0, spriteObjects.Length);
        Debug.Log(index);
        Debug.Log("jumlahAngka = " + jumlahAngka);

        if (jumlahAngka == 0)
        {
            offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
            startPos = transform.position + (Vector3.left * (offset.x * jumlahAngka / 2)) + (Vector3.down);
            Vector2 pos = new Vector3(startPos.x + (-1), startPos.y + offset.y);
            InstantiateBackground(pos, 0, index);
        }
        else if (jumlahAngka < 6 && jumlahAngka > 0)
        {
            offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
            startPos = transform.position + (Vector3.left * (offset.x * jumlahAngka / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }
        }
        else if(jumlahAngka < 11 && jumlahAngka > 5)
        {
            offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
            startPos = transform.position + (Vector3.left * (offset.x * 5 / 2)) + (Vector3.down);
            for (int x = 0; x < 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 5) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }
        }

        else if (jumlahAngka < 16 && jumlahAngka > 10)
        {
            offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
            startPos = transform.position + (Vector3.left * (offset.x * 5 / 2)) + (Vector3.down);
            for (int x = 0; x < 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 5 / 2)) + (Vector3.down);
            for (int x = 0; x < 5; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 10) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }
        }
        else if (jumlahAngka < 21 && jumlahAngka > 15)
        {
            offset = tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 10) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();
        }
        else if (jumlahAngka < 31 && jumlahAngka > 20 )
        {
            offset = new Vector2(1.5f,1.5f);
            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 20) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 20; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();
        }
        else if (jumlahAngka < 41 && jumlahAngka > 30)
        {
            offset = new Vector2(1.3f, 1.3f);
            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (-1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 30) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 30; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();
        }
        else if (jumlahAngka < 51 && jumlahAngka > 40)
        {
            offset = new Vector2(1.15f, 1.15f);
            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (-1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 40) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 40; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (3 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();

        }

        else if (jumlahAngka < 61 && jumlahAngka > 50)
        {
            offset = new Vector2(1f, 1f);
            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (-1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 10 / 2)) + (Vector3.down);
            for (int x = 0; x < 10; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (3 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 50) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 50; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (4 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();

        }

        else if (jumlahAngka < 76 && jumlahAngka > 60)
        {
            offset = new Vector2(1f, 1f);
            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (-1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 60) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 60; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (3 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();

        }

        else if (jumlahAngka < 91 && jumlahAngka > 75)
        {
            offset = new Vector2(0.8f, 0.8f);
            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (-1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 15 / 2)) + (Vector3.down);
            for (int x = 0; x < 15; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (3 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 75) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 75; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (4 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();

        }

        else if (jumlahAngka < 100 && jumlahAngka > 90)
        {
            offset = new Vector2(0.8f, 0.8f);
            startPos = transform.position + (Vector3.left * (offset.x * 20 / 2)) + (Vector3.down);
            for (int x = 0; x < 20; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (0 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 20 / 2)) + (Vector3.down);
            for (int x = 0; x < 20; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (1 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 20 / 2)) + (Vector3.down);
            for (int x = 0; x < 20; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (2 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * 20 / 2)) + (Vector3.down);
            for (int x = 0; x < 20; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (3 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            startPos = transform.position + (Vector3.left * (offset.x * (jumlahAngka - 80) / 2)) + (Vector3.down);
            for (int x = 0; x < jumlahAngka - 80; x++)
            {
                Vector2 pos = new Vector3(startPos.x + (x * offset.x), startPos.y + (4 * offset.y));
                InstantiateBackground(pos, x, index);
            }

            RandomAngka();

        }
    }

    private void InstantiateBackground(Vector2 pos, int x, int index)
    {
        if (jumlahAngka < 21)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";
            if (jumlahAngka != 0)
            {
                GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
                gameObject.tag = "icon";
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
            }
        }
        else if(jumlahAngka > 20 && jumlahAngka < 31)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";

            GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            gameObject.tag = "icon";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
        }
        else if(jumlahAngka > 30 && jumlahAngka < 41)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";

            GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            gameObject.tag = "icon";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
        }
        else if(jumlahAngka > 40 && jumlahAngka < 51)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";

            GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            gameObject.tag = "icon";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
        }
        else if (jumlahAngka > 50 && jumlahAngka < 76)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";

            GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            gameObject.tag = "icon";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
        }
        else if (jumlahAngka > 75 && jumlahAngka < 100)
        {
            GameObject backgroundTile = Instantiate(tilePrefab, pos, tilePrefab.transform.rotation);
            backgroundTile.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            backgroundTile.transform.parent = transform;
            backgroundTile.name = "(" + x + ")";
            backgroundTile.tag = "tile";

            GameObject gameObject = Instantiate(spritePrefab, pos, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.tag = "icon";
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteObjects[index];
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
    public void Nilai(int nilai)
    {
        if(nilai == jumlahAngka)
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
                panelSelesai.SetActive(false);
                panelSelanjutnya.SetActive(true);
                gameManager.scoreTextAkhir.text = "" + score;

                UnlockLevel();
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
            gameManager.scoreTextGame.text = "" + score;

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

    void RandomAngka()
    {
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
    IEnumerator DisableImage()
    {
        yield return new WaitForSeconds(1.5f);
        kamuSalah.SetActive(false);
        kamuBenar.SetActive(false);

        DestroyAll("tile");
        DestroyAll("icon");
        CreateTile();
    }

    void UnlockLevel()
    {
        switch (activeScene)
        {
            case 2:
                gamedata.unlockMengenalAngka02 = true;
                break;
            case 3:
                gamedata.unlockMengenalAngka03 = true;
                break;
            case 4:
                gamedata.unlockMengenalAngka04 = true;
                break;
            case 5:
                break;

        }
    }
}
