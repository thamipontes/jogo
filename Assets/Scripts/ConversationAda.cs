using UnityEngine;

/*
 * Classe: ConversationAda
 * Descrição: Ao colidir com o player, abra-se uma caixa de diálogo
 */
public class ConversationAda : MonoBehaviour
{
    //Expõe um campo para conectar o Script Tester e usar suas funções/atributos
    [SerializeField] Tester _tester;
    bool Conversa = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*
         * Se o objeto colidido tiver a tag Player, chama-se a função StartConvo que abre uma caixa de diálogo
         */
        if (other.gameObject.CompareTag("Player") && Conversa)
        {
            _tester.StartConvo();
            Conversa = false;
          //  Destroy(gameObject);
        }
    }
}
