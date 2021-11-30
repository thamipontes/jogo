using UnityEngine;

public class ChefaoMovimentation : MonoBehaviour
{
    private InimigoMovimentacao _inimigoMovimentacao;
    private Animator _animator;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _animator = GetComponentInParent<Animator>();
            _animator.SetBool("andando", true);
            _inimigoMovimentacao = GetComponentInParent<InimigoMovimentacao>();
            _inimigoMovimentacao.enabled = true;
        }
    }
}