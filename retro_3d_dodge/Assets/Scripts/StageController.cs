using UnityEngine;

public class StageController : MonoBehaviour
{
    public float rotationSpeed = 60f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        //transform.Rotate(0f, rotationSpeed, 0f);
    }
}
