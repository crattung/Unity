using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilScript : MonoBehaviour
{
    public GameObject Weapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(StartRecoil());
        }
    }

    IEnumerator StartRecoil()
    {
        Weapon.GetComponent<Animator>().Play("Recoil");
        yield return new WaitForSeconds(0.30f);
        Weapon.GetComponent<Animator>().Play("New State");
    }
}