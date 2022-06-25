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
    public Animator anim;
    public bool facingLeft = true;
    public Vector3 movimentacao;
    private void Start()
    {
        puzzleSpace.SetActive(false);
        puzzleArrow.SetActive(false);
        puzzleCheck.SetActive(false);
        puzzleMultiple.SetActive(false);
        anim.SetBool("andando", false);
    }
    private void Update()
    {       
        Anda();
              
        //transform.position += new Vector3(movementH, movementV, 0) * Time.deltaTime * MovementSpeed;
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
        if(movimentacao == Vector3.zero)
        {
            anim.SetBool("andando", false);
        }
    }
    public void Anda()
    {
        
        var movementH = Input.GetAxis("Horizontal");
        var movementV = Input.GetAxis("Vertical");
        movimentacao = new Vector3(movementH, movementV, 0) * Time.deltaTime * MovementSpeed;
        transform.position += movimentacao;
        if (movementH > 0 && !facingLeft)
        {
            Flip();
            anim.SetBool("andando", true);
        }
        else if (movementH < 0 && facingLeft)
        {
            Flip();
            anim.SetBool("andando", true);
        }
        //if (movementH == 0 || movementV == 0)
        //    anim.SetFloat("speed", 0f);
    }
    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
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
