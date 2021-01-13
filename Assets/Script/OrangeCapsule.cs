using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeCapsule : MonoBehaviour
{
    private int orangeCounter;

    public Text OrangeText;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            orangeCounter++;
            OrangeText.GetComponent<Text>().text = "Orange: " + orangeCounter;
            audioSource.Play();
        }
    }
}