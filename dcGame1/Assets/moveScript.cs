using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    float speed = 0.5f;
    float rotspeed = 300;
    float rot = 0;
    float gravity = 8;
    Vector3 moveDir = Vector3.zero;
    public static bool tap;
    public GameObject TapToStart;

    CharacterController kontrol;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //Başlangıç ayarlaması
        kontrol = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            Destroy(TapToStart);
        }
        
        
            if (Input.GetKey(KeyCode.W))
            {
                
                moveDir = new Vector3(0, 0, 1); //z ekseninde 1 birim hareket ettirdik
                moveDir *= speed;
                anim.SetInteger("komut", 1);
                moveDir = transform.TransformDirection(moveDir);
            }

            else if(Input.GetKey(KeyCode.S))
            {
            
                
                moveDir = new Vector3(0, 0, 0);
                anim.SetInteger("komut", 0);
            }

            else
            {
                
                moveDir = new Vector3(0, 0, 0);
                anim.SetInteger("komut", 0);
            }
        rot += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0); //y ekseninde değişim
        moveDir.y -= gravity * Time.deltaTime;
        kontrol.Move(moveDir * Time.deltaTime);
    }

  
   
}
