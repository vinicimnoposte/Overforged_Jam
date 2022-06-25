using UnityEngine;

public class CharacterBhvr : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public GameObject puzzleSpace;
    public GameObject puzzleArrow;
    public GameObject puzzleCheck;
    public GameObject puzzleMultiple;
    public int PuzzleActive = 0;
    public bool minigamefinished;

    private void Start()
    {
        puzzleSpace.SetActive(false);
        puzzleArrow.SetActive(false);
        puzzleCheck.SetActive(false);
        puzzleMultiple.SetActive(false);
    }
    private void Update()
    {
        var movementH = Input.GetAxis("Horizontal");
        var movementV = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementH, movementV, 0) * Time.deltaTime * MovementSpeed;
        if(PuzzleActive == 1 && !minigamefinished)
        {
                puzzleSpace.SetActive(true);
        }
        if(PuzzleActive == 2 && !minigamefinished)
        {
            puzzleArrow.SetActive(true);
        }
        if(PuzzleActive == 3 && !minigamefinished)
        {
            puzzleCheck.SetActive(true);
        }
        if(PuzzleActive == 4 && !minigamefinished)
        {
            puzzleMultiple.SetActive(true);
        }
    }

    public void SetStarter(int puzzleStarter)
    {
        PuzzleActive = puzzleStarter;
    }
    public void resetPuzzle()
    {
        minigamefinished = false;
    }
}
