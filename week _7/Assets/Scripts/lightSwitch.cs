using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{

    public GameObject TextDesplay;

    private bool playerArea;

    public GameObject lightSwitchOb; 
    // Start is called before the first frame update
    void Start()
    {
        playerArea = false;         //when player is not in area
        TextDesplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerArea && Input.GetKeyDown(KeyCode.F))
        {
            lightSwitchOb.SetActive(!lightSwitchOb.activeSelf); // activate light
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextDesplay.SetActive(true);
            playerArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextDesplay.SetActive(false);
            playerArea = false;
        }
    }


}
