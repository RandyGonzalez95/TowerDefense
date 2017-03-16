using UnityEngine;

public class Shop : MonoBehaviour
{

    
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseFlower()
    {
        Debug.Log("Flower selected");
        buildManager.SetObjectToBuild(buildManager.flower);

        if (buildManager.flower == null)
        {
            Debug.Log("build manager is null at flower shop");
        }
    }

    public void PurchasePeaShooter()
    {
        Debug.Log("pea selected");

        buildManager.SetObjectToBuild(buildManager.peaShooter);

        if (buildManager.peaShooter == null)
        {
            Debug.Log("build manager is null at pea shop");
        }
    }

    public void PurchaseMultiShooter()
    {
        Debug.Log("pea2 selected");

        buildManager.SetObjectToBuild(buildManager.multiShooter);

        if (buildManager.multiShooter == null)
        {

        }
    }

}
