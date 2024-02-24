using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TongueAttack : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Extended = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack() 
    {
        if (Extended == false) 
        {   
            transform.localScale = new Vector3(1.5f, 0f, 0f);
        }
        else if (Extended == true) 
        {
            transform.localScale = new Vector3(1.5f,5f,0f);
            yield return new WaitForSeconds(2f);
            Extended = false;
        }
        if (Input.GetButtonDown("Attack") && Extended == false) 
        {
            Extended = true;
        }
    }

}   
