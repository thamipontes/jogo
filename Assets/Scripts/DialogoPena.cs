using UnityEngine;

/*
 * Classe: DialogoPena
 * Descrição: Ao colidir com o player, abra-se uma caixa de diálogo
 */
public class DialogoPena : MonoBehaviour
{
    /*
     * Nome: OnTriggerEnter2D
     * Parâmetro: Objeto colidido
     * Descrição: função que percebe que houve uma colisão trigger entre dois ou mais objetos
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        var target = other.gameObject;
        /*
         * Se o objeto colidido tiver a tag Player, destroi o objeto que possui esse script depois de 0.2 segundos
         */
        if (target.CompareTag("Player"))
        {
            Destroy(gameObject, 0.2f);
        }
    }
}