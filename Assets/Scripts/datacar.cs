using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datacar : MonoBehaviour
{
    public static datacar main;
 public string playernamet;

    private void Awake()
    {
        main = this;
    }

    private void Update()
    {

        playernamet = menuui.main.playername;
        if (Input.GetKeyDown(KeyCode.R))
        {
            print(playernamet);
        }
    }

}
