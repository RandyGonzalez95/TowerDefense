using System.Collections;
using UnityEngine;

public class Shop : MonoBehaviour
{

    
    BuildManager buildManager;
    PlayerManager player;
    public GameObject panel;

    void Start()
    {
        buildManager = BuildManager.instance;
        player = PlayerManager.instance;
    }

    public void PurchaseFlower()
    {
        if (player.currentSunAmount >= 50)
        {
            buildManager.SetObjectToBuild(buildManager.flower);
            player.Purchase(50);
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);

        }     

    }

    public void PurchasePeaShooter()
    {
        if (player.currentSunAmount >= 200)
        {
            buildManager.SetObjectToBuild(buildManager.peaShooter);
            player.Purchase(200);
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
 
        }
          
    }

    public void PurchaseMultiShooter()
    {       
        if(player.currentSunAmount >= 1000)
        {
            buildManager.SetObjectToBuild(buildManager.multiShooter);
            player.Purchase(1000);
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
      
        }
             
    }



}
