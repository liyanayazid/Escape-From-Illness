using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hp : MonoBehaviour
{
    
    public static float Health = 5;
    public float healthPoint = 5;
    public GameObject loseMenuUI;

    public GameObject Health1, Health2, Health3, Health4, Health5;

    public static bool GamePaused;

    public float countDownStartvalue = 1;

    public Text countdowntext;

    public AudioSource soundgameOver;
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ExtraTime")
        {
            countDownStartvalue += 300;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "ExtraHp")
        {
            if (Hp.Health < 5)
            {
                Hp.Health += 1;
                Destroy(other.gameObject);

            }
            
        }
    }


void gameover()
    {
        soundgameOver.Play();
        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        Health = 5;
    }

    public void Update()
    {
        GamePaused = PauseMenu.GameIsPaused;

        healthPoint = Health;

        if (Health == 5)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(true);
        }


        if (Health == 4)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(true);
            Health5.SetActive(false);
        }

        else if (Health == 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
            Health4.SetActive(false);
            Health5.SetActive(false);
        }

        else if (Health == 2)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
        }

        else if (Health == 1)
        {
            Health1.SetActive(true);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);
        }

        else if (Health == 0)
        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(false);
            Health4.SetActive(false);
            Health5.SetActive(false);

            gameover();
        }


            if (countDownStartvalue >= 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartvalue);
                countdowntext.text = "Timer:" + spanTime.Minutes + ":" + spanTime.Seconds;
                countDownStartvalue -= 1 * Time.deltaTime;
            }
            else
            {
                gameover();
            }

        }


    

}
