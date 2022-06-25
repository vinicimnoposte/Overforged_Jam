using UnityEngine;

public class CharacterBhvr : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public GameObject puzzleSpace;
    public GameObject puzzleArrow;

    private void Start()
    {
        puzzleSpace.SetActive(false);
        puzzleArrow.SetActive(false);
    }
    private void Update()
    {
        var movementH = Input.GetAxis("Horizontal");
        var movementV = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementH, movementV, 0) * Time.deltaTime * MovementSpeed;
        if(Input.GetKeyDown("e"))
        {
            puzzleSpace.SetActive(true);
        }
        if(Input.GetKeyDown("q"))
        {
            puzzleArrow.SetActive(true);
        }
    }
}
