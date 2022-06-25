using UnityEngine;

public class CharacterBhvr : MonoBehaviour
{
    public float MovementSpeed = 1f;
   
    private void Update()
    {
        var movementH = Input.GetAxis("Horizontal");
        var movementV = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementH, movementV, 0) * Time.deltaTime * MovementSpeed;
    }
}
