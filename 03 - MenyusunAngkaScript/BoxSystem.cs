using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BoxSystem : MonoBehaviour
{
    MenyusunAngkaSystem menyusunAngka;
    public int angka1, angka2, angka3;
    Vector3 posisiTengah;

    private void Start()
    {
        posisiTengah = this.transform.localPosition;
        menyusunAngka = FindObjectOfType<MenyusunAngkaSystem>();
        Debug.Log(posisiTengah + " " + this.gameObject.tag);
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        Debug.Log("OnCollisionEnter");
        if (this.gameObject.tag == "kotak1" && !menyusunAngka.status1)
        {
            Debug.Log(posisiTengah);
            string angkaPertama = collision.gameObject.GetComponent<Text>().text;
            angka1 = int.Parse(angkaPertama);
            menyusunAngka.NomorPertama(angka1);
            collision.gameObject.transform.localPosition = posisiTengah;
            collision.gameObject.GetComponent<MovingSystem>().enabled = false;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
            this.gameObject.GetComponent<BoxSystem>().enabled = false;
        }
        else if (this.gameObject.tag == "kotak2" && !menyusunAngka.status2)
        {
            Debug.Log(posisiTengah);
            string angkaKedua = collision.gameObject.GetComponent<Text>().text;
            angka2 = int.Parse(angkaKedua);
            menyusunAngka.NomorKedua(angka2);
            collision.gameObject.transform.localPosition = posisiTengah;
            collision.gameObject.GetComponent<MovingSystem>().enabled = false;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
            this.gameObject.GetComponent<BoxSystem>().enabled = false;
        }
        else if (this.gameObject.tag == "kotak3" && !menyusunAngka.status3)
        {
            Debug.Log(posisiTengah);
            string angkaKetiga = collision.gameObject.GetComponent<Text>().text;
            angka3 = int.Parse(angkaKetiga);
            menyusunAngka.NomorKetiga(angka3);
            collision.gameObject.transform.localPosition = posisiTengah;
            collision.gameObject.GetComponent<MovingSystem>().enabled = false;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
            this.gameObject.GetComponent<BoxSystem>().enabled = false;
        }
        else
        {
            collision.gameObject.transform.localPosition = collision.gameObject.GetComponent<MovingSystem>().posisiAwal;
        }
    }
}
