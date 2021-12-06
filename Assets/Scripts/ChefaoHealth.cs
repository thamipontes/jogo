using System.Collections;
using UnityEngine;

public class ChefaoHealth : MonoBehaviour
{
    public Animator animator;
    public int vidaChefao = 200;
    public GameObject portal;

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
            Instantiate(portal, portal.transform.position, transform.rotation);
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