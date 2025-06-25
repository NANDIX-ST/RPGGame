using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public GameObject prefabGuerreiro;
    public GameObject prefabNecromante;
    public GameObject prefabEsqueleto;
    private Personagem guerreiro;
    private Necromante necromante;

    void Start()
    {
        // Instanciar guerreiro
        GameObject guerreiroObj = Instantiate(prefabGuerreiro, new Vector3(-5, 0, 0), Quaternion.identity);
        guerreiro = guerreiroObj.AddComponent<Personagem>();
        guerreiro.Nome = "Guerreiro";
        guerreiro.Nivel = 5;
        guerreiro.Vida = 150;
        guerreiro.Mana = 30;

        // Instanciar necromante
        GameObject necroObj = Instantiate(prefabNecromante, new Vector3(0, 0, 0), Quaternion.identity);
        necromante = necroObj.AddComponent<Necromante>();
        necromante.Nome = "Morgath";
        necromante.Nivel = 7;
        necromante.Vida = 100;
        necromante.Mana = 200;

        // Configurar referência do prefab esqueleto no necromante
        necromante.esqueletoPrefab = prefabEsqueleto;
        necromante.pontoInvocacao = necroObj.transform;  // invocar ao redor do próprio necromante

        // Debug logs
        Debug.Log($"Personagem: {guerreiro.Nome}, Nível: {guerreiro.Nivel}, Vida: {guerreiro.Vida}, Mana: {guerreiro.Mana}");
        Debug.Log($"Necromante: {necromante.Nome}, Nível: {necromante.Nivel}, Vida: {necromante.Vida}, Mana: {necromante.Mana}, Habilidade: {necromante.HabilidadeEspecial}");

        // Usar habilidades do necromante
        necromante.InvocarEsqueletos();
        necromante.UsarHabilidadeEspecial();

        // Comparar níveis
        Debug.Log(necromante.CompararNivel(guerreiro));
    }
}