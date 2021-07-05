using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparingBoxSystem : MonoBehaviour
{
    MembandingkanAngkaSystem membandingkanAngkaSystem;
    public int angkaKiri, angkaKanan;
    Vector3 posisiTengah;

    private void Start()
    {
        membandingkanAngkaSystem = FindObjectOfType<MembandingkanAngkaSystem>();
        posisiTengah = this.transform.localPosition;
    }

    public int AngkaKiri
    {
        set { angkaKiri = value; }
    }

    public int AngkaKanan
    {
        set { angkaKanan = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.localPosition = posisiTengah;
        collision.gameObject.GetComponent<MovingSystem>().enabled = false;
        if (collision.gameObject.tag == "samaDengan" && angkaKiri == angkaKanan)
        {
            membandingkanAngkaSystem.skor += 1;
            membandingkanAngkaSystem.totalSkor += 1;
            membandingkanAngkaSystem.KamuBenar();
        }
        else if(collision.gameObject.tag == "lebihBesar" && angkaKiri > angkaKanan)
        {
            membandingkanAngkaSystem.skor += 1;
            membandingkanAngkaSystem.totalSkor += 1;
            membandingkanAngkaSystem.KamuBenar();

        }
        else if(collision.gameObject.tag == "lebihKecil" && angkaKiri < angkaKanan)
        {
            membandingkanAngkaSystem.skor += 1;
            membandingkanAngkaSystem.totalSkor += 1;
            membandingkanAngkaSystem.KamuBenar();
        }
        else
        {
            membandingkanAngkaSystem.KamuSalah();
        }

        Debug.Log("OnCollisionEnter");
    }
}
