using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private SpriteRenderer rend;
    private Color startColor;

    BuildManager buildManager;

    private GameObject tower;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startColor = rend.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if(buildManager.GetObjectToBuild() == null)
        { 
            return;
        }

        if(tower != null)
        {
            //Display On Screen that we can not build here
            return;
        }


        GameObject objectToBuild = buildManager.GetObjectToBuild();
        tower = (GameObject)Instantiate(objectToBuild, transform.position, transform.rotation);
        buildManager.SetObjectToBuild(null);

    }

    void OnMouseEnter()
    {
        if(buildManager.GetObjectToBuild() == null)
        {
            return;
        }

        rend.color = Color.grey;
    }

    void OnMouseExit()
    {
        rend.color = startColor;
    }
}
