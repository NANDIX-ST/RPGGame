using UnityEngine;
public class Druida : Personagem
{
    private bool emFormaDeLobo;

    public void AtivarFormaDeLobo()
    {
        emFormaDeLobo = true;
        Debug.Log($"{GetNome()} ativou a Forma de Lobo!");
    }

    public void DesativarFormaDeLobo()
    {
        emFormaDeLobo = false;
        Debug.Log($"{GetNome()} voltou à forma normal.");
    }

    public bool EstaEmFormaDeLobo()
    {
        return emFormaDeLobo;
    }
}