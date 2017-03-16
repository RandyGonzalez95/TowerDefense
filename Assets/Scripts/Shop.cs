using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject flower, peaShooter, multiShooter;
    
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseFlower()
    {
        buildManager.SetObjectToBuild(flower);
    }

    public void PurchasePeaShooter()
    {
        buildManager.SetObjectToBuild(peaShooter);
    }

    public void PurchaseMultiShooter()
    {
        buildManager.SetObjectToBuild(multiShooter);
    }

}
