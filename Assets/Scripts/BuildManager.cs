using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject objectToBuild;


    public GameObject GetObjectToBuild()
    {

        return objectToBuild;
    }

    public void SetObjectToBuild(GameObject choice)
    {
        objectToBuild = choice;
    }

}
