using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We'll move the vehicle forward
        /*transform.Translate(0,0,1) works the same Time.delta için tüm koord ayrı yazmak lazım boylesı daha kısa
 Vector3.right → (1, 0, 0)
 Vector3.left → (-1, 0, 0)
 Vector3.up → (0, 1, 0)
 Vector3.down → (0, -1, 0)
 Vector3.forward → (0, 0, 1)
 Vector3.back → (0, 0, -1)*/

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    } 
}
