using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    
    public GameObject redObj;

  
    [SerializeField]
    private GameObject blueObj;

    void Start()
    {

        Application.targetFrameRate = 60;

        if (redObj != null)
        {
            Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
        }

        
        if (blueObj != null)
        {
            Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
        }
    }
}
