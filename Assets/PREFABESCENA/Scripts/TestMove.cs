using UnityEngine;

public class TestMove : MonoBehaviour
{
    private float speed = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movePlayer = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movePlayer * speed * Time.deltaTime);
    }

}
