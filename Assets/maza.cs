﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class maza : MonoBehaviour
{
    public float Speed;
    public Transform Player_Transform,TargetTransform;
    public GameObject Win,Lose;

    public float Time_Game=60;

    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
            Time.timeScale=1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0,0,-Speed*Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Transform");

            transform.Rotate(new Vector3(0,0,Speed*Time.deltaTime));
          
            
        }

        if(Vector3.Distance(Player_Transform.transform.position,TargetTransform.transform.position)<0.5f){
            // print("you winning");
            Time.timeScale=0;
            Win.SetActive(true);
        }

    if(Time_Game > 0){
        Time_Game-= 1 * Time.deltaTime;
    }

    if(Time_Game <= 0){
            Time.timeScale=0;
        Lose.SetActive(true);
    }

    myText.text = Time_Game.ToString("00");

    }

    public void Click_Restart(){

            Time.timeScale=1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Click_Exit(){
 
        Application.Quit();

    }


    
}
