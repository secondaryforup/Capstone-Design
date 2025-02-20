﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition_Ham : MonoBehaviour
{


    public Vector3 offset;
    public Vector3 offset2;
    public GameObject player;     //GameObject 플레이어
    private PlayerInput playerinput;  //player input 스크립트
                                      
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position;  //player의 위치를 읽어 온다.
        transform.Translate(new Vector3(0f, 0f, 0.2f));   //적절한 위치로 카메라를 옮긴다.
        transform.position = transform.position + offset;



    }

    // Update is called once per frame
    void Update()
    {
        CameraTurn();
        transform.Rotate(0, 0, 0);

    }



    private void CameraTurn()
    {
        //player가 회전할때 카메라의 위치를 수정한다.
        if (player.transform.eulerAngles.y >= 270 && player.transform.eulerAngles.y <= 360)
        {
            transform.position = player.transform.position + new Vector3(-player.transform.eulerAngles.y / 400, 6.6f, -400 / player.transform.eulerAngles.y);
            transform.position = transform.position + offset2;
        }

    }

}
