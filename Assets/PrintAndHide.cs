using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int blueRandom;

    private void Start()
    {
        blueRandom = Random.Range(150, 251); // Random integer between 150 and 250, inclusive
    }

    private void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == blueRandom)
        {
            rend.enabled = false;
        }
    }
}
