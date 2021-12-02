using System.Collections;
using UnityEngine;

public class ChefaoHealth : MonoBehaviour
{
    public Animator animator;
    public int vidaChefao = 10;

    public

        // Start is called before the first frame update
        void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void Damage()
    {
        vidaChefao--;
        StartCoroutine(damageTime());

        if (vidaChefao <= 1)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator damageTime()
    {
        animator.SetBool("dano", true);
        // MusicManager.playSound("machucar1");
        yield return new WaitForSecondsRealtime(0.75f);
        animator.SetBool("dano", false);
    }
}