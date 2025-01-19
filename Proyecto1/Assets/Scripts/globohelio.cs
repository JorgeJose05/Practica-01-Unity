using UnityEngine;

public class globohelio : MonoBehaviour
{
    
private SpriteRenderer blockRenderer;

Vector2 position2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float riseSpeed = 5.0f;
    private float otraSpeed = 2.0f;
    void Start()
    {
        blockRenderer = GetComponent<SpriteRenderer>();
        // Crear un Vector2 para la posiciÃ³n
         //position2D = new Vector2(1.0f, 2.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f)* riseSpeed * Time.deltaTime;
        // Asignar la posición al Transform del GameObject (en un contexto 2D)
        //transform.position = new Vector3(position2D.x, position2D.y, 0f);
        // Aplicar el movimiento al Transform del GameObject

       
        if (moveY == 0)
        {
            movement.y += riseSpeed * Time.deltaTime;
        }
        
        transform.Translate(movement);
        //movement = new Vector3(moveX, moveY+1, 0f);
        //transform.Translate(movement * 3 * Time.deltaTime);
         
        //position2D = new Vector3(transform.position.x, transform.position.y,0f);

    }
}
