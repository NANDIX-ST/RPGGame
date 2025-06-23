using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        // Criando personagens
        Personagem p1 = new Personagem();
        p1.SetNome("Guerreiro");
        p1.SetNivel(10);
        p1.SetVida(100);
        p1.SetMana(30);

        Druida druida1 = new Druida();
        druida1.SetNome("Eldrin");
        druida1.SetNivel(12);
        druida1.SetVida(80);
        druida1.SetMana(100);

        // Ativar habilidade especial
        druida1.AtivarFormaDeLobo();

        // Mostrar os dados com Debug.Log
        Debug.Log($"Personagem 1: {p1.GetNome()}, Nível: {p1.GetNivel()}, Vida: {p1.GetVida()}, Mana: {p1.GetMana()}");
        Debug.Log($"Druida: {druida1.GetNome()}, Nível: {druida1.GetNivel()}, Vida: {druida1.GetVida()}, Mana: {druida1.GetMana()}, Forma de Lobo: {druida1.EstaEmFormaDeLobo()}");

        // Comparação
        string resultadoComparacao = druida1.CompararForca(p1);
        Debug.Log("Resultado da comparação: " + resultadoComparacao);
    }
}