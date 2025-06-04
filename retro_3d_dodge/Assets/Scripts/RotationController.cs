using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Transform childTransform;


    void Start()
    {
        // 자신 위치 전역
        transform.position = new Vector3(0, -1, 0);
        // 자식 위치 지역
        childTransform.localPosition = new Vector3(0, 2, 0);

        // 자신 회전 전역
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        // 자식 회전 지역
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) 
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }

    }
}
