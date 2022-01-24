using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject UIWin;
    public AudioSource WinSound;
    public GameObject star1, star2, star3, star4, star5;
    public GameObject emptystar1, emptystar2, emptystar3, emptystar4, emptystar5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIWin.SetActive(true);
            WinSound.Play();
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            if (Hp.Health == 5) 
            {
                emptystar1.SetActive(true);
                emptystar2.SetActive(true);
                emptystar3.SetActive(true);
                emptystar4.SetActive(true);
                emptystar5.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(true);
            }

            else if (Hp.Health == 4)
            {
                emptystar1.SetActive(true);
                emptystar2.SetActive(true);
                emptystar3.SetActive(true);
                emptystar4.SetActive(true);
                emptystar5.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(false);
            }
            else if (Hp.Health == 3)
            {
                emptystar1.SetActive(true);
                emptystar2.SetActive(true);
                emptystar3.SetActive(true);
                emptystar4.SetActive(true);
                emptystar5.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(false);
                star5.SetActive(false);
            }
            else if (Hp.Health == 2)
            {
                emptystar1.SetActive(true);
                emptystar2.SetActive(true);
                emptystar3.SetActive(true);
                emptystar4.SetActive(true);
                emptystar5.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);
                star4.SetActive(false);
                star5.SetActive(false);
            }
            else if (Hp.Health == 1)
            {
                emptystar1.SetActive(true);
                emptystar2.SetActive(true);
                emptystar3.SetActive(true);
                emptystar4.SetActive(true);
                emptystar5.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(false);
                star4.SetActive(false);
                star5.SetActive(false);
            }
        }

    }
}
