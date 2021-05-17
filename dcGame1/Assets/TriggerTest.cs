using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerTest : MonoBehaviour
{
    public Material[] material;
    Renderer render;
    GameObject rotaterMe, rotaterAmy, rotaterRemy, rotaterLeonard;
    

    private void Awake()
    {
    }

    void Start()
    {
        rotaterMe = GameObject.Find("CubeMe");
        rotaterAmy = GameObject.Find("CubeAmy");
        rotaterRemy = GameObject.Find("CubeRemy");
        rotaterLeonard = GameObject.Find("CubeLeonard");
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        

        
        if (other.gameObject.tag=="Player")
        {
            render = GetComponent<Renderer>();
            if (render.material.color != Color.blue && render.material.color != Color.red && render.material.color != Color.yellow && render.material.color != Color.green)
            {
                render.material.color = Color.blue;
                Score.skorMe += 1;
                rotaterMe.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
            }
            else
            {
                if (render.material.color == Color.green)
                {
                    render.material.color = Color.blue;
                    Score.skorMe += 1;
                    --Score.skorAmy;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                    rotaterAmy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);


                }
                else if (render.material.color == Color.red)
                {
                    render.material.color = Color.blue;
                    Score.skorMe += 1;
                    --Score.skorLeonard;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);


                }
                else if (render.material.color == Color.yellow)
                {
                    render.material.color = Color.blue;
                    Score.skorMe += 1;
                    --Score.skorRemy;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);


                }
                else if (render.material.color==Color.blue)
                {
                }
            }
        }
        else if (other.gameObject.tag == "Amy")
        {
            render = GetComponent<Renderer>();
            if (render.material.color != Color.blue && render.material.color != Color.red && render.material.color != Color.yellow && render.material.color != Color.green)
            {
                render.material.color = Color.green;
                Score.skorAmy += 1;
                rotaterAmy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
            }
            else
            {
                if (render.material.color == Color.blue)
                {
                    render.material.color = Color.green;
                    Score.skorAmy += 1;
                    --Score.skorMe;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterAmy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
                else if (render.material.color == Color.red)
                {
                    render.material.color = Color.green;
                    Score.skorAmy += 1;
                    --Score.skorLeonard;
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                }
                else if (render.material.color == Color.yellow)
                {
                    render.material.color = Color.green;
                    Score.skorAmy += 1;
                    --Score.skorRemy;
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterAmy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
            }
        }
        else if (other.gameObject.tag == "Leonard")
        {
            render = GetComponent<Renderer>();

            if (render.material.color != Color.blue && render.material.color != Color.red && render.material.color != Color.yellow && render.material.color != Color.green)
            {
                render.material.color = Color.red;
                Score.skorLeonard += 1;
                rotaterLeonard.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);

            }
            else
            {
                if (render.material.color == Color.green)
                {
                    render.material.color = Color.red;
                    Score.skorLeonard += 1;
                    --Score.skorAmy;
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                    rotaterAmy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                }
                else if (render.material.color == Color.blue)
                {
                    render.material.color = Color.red;
                    Score.skorLeonard += 1;
                    --Score.skorMe;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
                else if (render.material.color == Color.yellow)
                {
                    render.material.color = Color.red;
                    Score.skorLeonard += 1;
                    --Score.skorRemy;
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
            }
        }

        else if (other.gameObject.tag == "Remy")
        {
            render = GetComponent<Renderer>();
            
            if (render.material.color != Color.blue && render.material.color != Color.red && render.material.color != Color.yellow && render.material.color != Color.green)
            {
                render.material.color = Color.yellow;
                Score.skorRemy += 1;
                rotaterRemy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
            }
            else
            {
                if (render.material.color == Color.green)
                {
                    render.material.color = Color.yellow;
                    --Score.skorAmy;
                    Score.skorRemy += 1;
                    rotaterAmy.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
                else if (render.material.color == Color.red)
                {
                    --Score.skorLeonard;
                    rotaterLeonard.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    render.material.color = Color.yellow;
                    Score.skorRemy += 1;
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
                else if (render.material.color == Color.blue)
                {
                    --Score.skorMe;
                    render.material.color = Color.yellow;
                    Score.skorRemy += 1;
                    rotaterMe.gameObject.transform.localScale += new Vector3(0, -0.1f, 0);
                    rotaterRemy.gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
                }
            }
        }
    }
    }

