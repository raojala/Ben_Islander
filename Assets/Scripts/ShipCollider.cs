using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipCollider : MonoBehaviour
{

    public AudioClip blip;
    private AudioSource source;
    public bool collision;

    private void Start()
    {

        source = GetComponent<AudioSource>();
        collision = false;
    }
    private void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy1")
        {
            if (collision == false)
            {
                source.PlayOneShot(blip);
                collision = true;
                Invoke("Load", 1);
            }
        }

    }
    void Load()
    {
        collision = false;
    }

}
