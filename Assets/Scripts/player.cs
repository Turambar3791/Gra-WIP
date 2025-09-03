using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Działa");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Debug.Log("Klik");
    }
}
