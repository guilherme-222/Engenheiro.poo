using UnityEngine;

public class TesteJogo : MonoBehaviour
{
    void Start()
    {
        Engenheiro eng = new Engenheiro();
        eng.SetNome("Atlas");
        eng.SetNivel(10);
        eng.SetVida(120);
        eng.SetForca(25);
        eng.numeroDeInvecoes = 3;
        eng.turretAtiva = false;

        Debug.Log("Personagem: " + eng.GetNome());
        Debug.Log("Nível: " + eng.GetNivel());
        Debug.Log("Vida: " + eng.GetVida());
        Debug.Log("Força: " + eng.GetForca());
        Debug.Log("Invenções: " + eng.numeroDeInvecoes);
        Debug.Log("Turret Ativa: " + eng.turretAtiva);

        eng.CriarInvencao();
        eng.UsarHabilidadeEspecial();

        // Criando outro personagem para comparação
        Personagem outro = new Personagem();
        outro.SetNome("Mercenário");
        outro.SetNivel(8);
        eng.CompararNivel(outro);
    }
}
