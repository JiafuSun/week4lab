using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    
    public GameObject redObj;

  
    [SerializeField]
    private GameObject blueObj;

    void Start()
    {

        Application.targetFrameRate = 60;

        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }
}
