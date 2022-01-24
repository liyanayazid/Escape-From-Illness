using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;
    public GameObject Virus;
    public AudioSource painSound;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);


    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            nav.speed = 0;
            Hp.Health -= 1;
            painSound.Play();

            StartCoroutine(ShowAndHide(Virus, 3.0f)); // 0.3 second
        }
    }

    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        yield return new WaitForSeconds(delay);
        nav.speed = 2;
        nav.SetDestination(target.position);
    }
}
