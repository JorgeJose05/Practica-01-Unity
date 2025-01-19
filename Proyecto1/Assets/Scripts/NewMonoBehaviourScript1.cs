using UnityEngine;

public class movimientoFantasma : MonoBehaviour
{
    private float riseSpeed = 5.0f;
    private float otraSpeed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f)* riseSpeed * Time.deltaTime;
        
        transform.Translate(movement);
        
    }
}
