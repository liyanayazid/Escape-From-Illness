using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Script : MonoBehaviour
{
    public GameObject explodeEffect;
    public GameObject Trap;
    public AudioSource ExplosionSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            explodeEffect.SetActive(true);
            StartCoroutine(ShowAndHide(Trap, 0.3f)); // 0.3 second
            ExplosionSound.Play();
            Hp.Health -= 1;
        }
        
    }

    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        yield return new WaitForSeconds(delay);
        Trap.SetActive(false);
    }



}
