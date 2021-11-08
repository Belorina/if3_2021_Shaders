using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    // allez chercher renderer - pour modifier info material

    private MeshRenderer render;        // pas appeler renderer car y a deja un truc qui s appell comme ca
    public float countDown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //    if (countDown == 1f)
        //    {
        //        countDown = 0f;
        //    }

    }

    void OnMouseDown()
    {
        if (countDown != 1)
        {
            countDown += Time.deltaTime;
        }
        else
        {
            countDown = 0;
        }

        render.material.SetFloat("_Dissolution", countDown);         // "metre ref de proprietee" : see referance dans shadergraph 

    }

}
