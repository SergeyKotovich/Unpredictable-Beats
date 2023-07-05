using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    private static readonly int VerticalInput = Animator.StringToHash("verticalInput");
    private static readonly int HorizontalInput = Animator.StringToHash("horizontalInput");
    private readonly string[] _listAttack = {"firstAttack","secondAttack","thirdAttack"};
    private float _verticalInput;
    private float _horizontalInput;
    


    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");
        _animator.SetFloat(VerticalInput, _verticalInput);
        _animator.SetFloat(HorizontalInput,_horizontalInput);


        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        var randomAttack = GetRandomAttack();
        _animator.SetTrigger(randomAttack);

    }

    

    private string GetRandomAttack()
    {
        var randomIndex = Random.Range(0, 10);
        switch (randomIndex)
        {
            case <= 5:
                return _listAttack[0];
            case <= 7:
                return _listAttack[1];
            case >= 8:
                return _listAttack[2];
        }
    }
}
