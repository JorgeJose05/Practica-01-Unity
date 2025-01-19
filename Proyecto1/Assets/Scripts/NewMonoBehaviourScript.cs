using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

private SpriteRenderer blockRenderer;
private Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blockRenderer = GetComponent<SpriteRenderer>();
        originalColor = blockRenderer.color;
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnCollisionEnter2D(Collision2D collision){
                    
                    blockRenderer.color = Color.yellow;
                    StartCoroutine(ChangeColorBack());
                }

    IEnumerator ChangeColorBack()
    {
        yield return new WaitForSeconds(1);
        blockRenderer.color = originalColor;
        
    }

}
