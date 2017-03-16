using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject flower, peaShooter, multiShooter;
    private GameObject objectToBuild;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    public GameObject GetObjectToBuild()
    {
        if(objectToBuild == null)
        {
           
        }
        return objectToBuild;
    }

    public void SetObjectToBuild(GameObject choice)
    {
        objectToBuild = choice;
    }

}
