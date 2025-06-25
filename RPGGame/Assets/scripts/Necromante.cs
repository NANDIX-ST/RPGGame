using UnityEngine;

public class Necromante : Personagem
{
    [SerializeField] public GameObject esqueletoPrefab;  // prefab para invocar esqueletos
    [SerializeField] public Transform pontoInvocacao;   // onde invocar os esqueletos

    private string habilidadeEspecial = "Ressurreição";

    public string HabilidadeEspecial
    {
        get => habilidadeEspecial;
    }

    public void InvocarEsqueletos()
    {
        if (esqueletoPrefab == null || pontoInvocacao == null)
        {
            Debug.LogWarning("Prefab ou ponto de invocação não configurados!");
            return;
        }

        // Invocar 3 esqueletos em posições ligeiramente deslocadas
        for (int i = 0; i < 3; i++)
        {
            Vector3 posicaoInvocacao = pontoInvocacao.position + new Vector3(i * 2, 0, 0);
            Instantiate(esqueletoPrefab, posicaoInvocacao, Quaternion.identity);
        }

        Debug.Log($"{Nome} invocou esqueletos do submundo!");
    }

    public void UsarHabilidadeEspecial()
    {
        // Aqui podemos fazer algum efeito visual ou apenas logar
        Debug.Log($"{Nome} usou a habilidade especial: {habilidadeEspecial}!");
        // Você pode adicionar partículas, animações, etc, aqui.
    }
}