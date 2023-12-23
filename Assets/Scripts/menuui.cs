using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class menuui : MonoBehaviour
{
    public string playername;
  public GameObject inputfield;
    public GameObject datacar;
    public static menuui main;

    // Start is called before the first frame update
    void Awake()
    {
        main = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            print(playername);
        }
        
    }

   public void loadmainscene()
    {
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(datacar);
    }

   public void getplayernaem()
    {
        playername = inputfield.GetComponent<TMP_InputField>().text;
    }



}
