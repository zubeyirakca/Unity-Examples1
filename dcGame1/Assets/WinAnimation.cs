using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAnimation : MonoBehaviour
{
    Animator anim, anim2, anim3, anim4;
    int isMeVictoryHash;
    int saniye = 15;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
        anim3 = GetComponent<Animator>();
        anim4 = GetComponent<Animator>();
        InvokeRepeating("saniye_azalt", 0.0f, 1.0f);
    }

    void Update()
    {
    }

    void saniye_azalt()
    {
        saniye--;
        Debug.Log(saniye.ToString());
        if (saniye == 0)
        {
            CancelInvoke("saniye_azalt");
            StartCoroutine("StopAnimator");
            EnYuksekSkor();
        }
    }

    IEnumerator StopAnimator()
    {
        yield return new WaitForSeconds(1f);

    }
    private void EnYuksekSkor()
    {
        StopAnimator();
        if (Score.skorMe > Score.skorAmy && Score.skorMe > Score.skorLeonard && Score.skorMe > Score.skorRemy)
        {
            Debug.Log("En Yüksek Skor Benim, Skorum:" + Score.skorMe);
            anim.SetTrigger("SetTrigger");
        }

        else if (Score.skorAmy > Score.skorMe && Score.skorAmy > Score.skorLeonard && Score.skorAmy > Score.skorRemy)
        {
            Debug.Log("En Yüksek Skor Amy, Skoru:" + Score.skorAmy);
            anim2.SetTrigger("SetTrigger2");
        }

        else if (Score.skorLeonard > Score.skorMe && Score.skorLeonard > Score.skorAmy && Score.skorLeonard > Score.skorRemy)
        {
            Debug.Log("En Yüksek Skor Leonard, Skoru:" + Score.skorLeonard);
            anim3.SetTrigger("SetTrigger3");
        }

        else if (Score.skorRemy > Score.skorMe && Score.skorRemy > Score.skorAmy && Score.skorRemy > Score.skorLeonard)
        {
            Debug.Log("En Yüksek Skor Remy, Skoru:" + Score.skorRemy);
            anim4.SetTrigger("SetTrigger4");
        }

        }
       
    }

