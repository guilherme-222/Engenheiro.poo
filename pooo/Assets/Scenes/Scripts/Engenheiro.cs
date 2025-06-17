using UnityEngine;

public class Engenheiro : Personagem
{
    public int numeroDeInvecoes;
    public bool turretAtiva;

    public void ConstruirTurret()
    {
        turretAtiva = true;
        Debug.Log($"{nome} construiu uma turret!");
    }

    public void UsarHabilidadeEspecial()
    {
        if (!turretAtiva)
        {
            ConstruirTurret();
            Debug.Log($"{nome} ativou sua habilidade especial: Turret Automática!");
        }
        else
        {
            Debug.Log($"{nome} já possui uma turret ativa.");
        }
    }

    public void CriarInvencao()
    {
        numeroDeInvecoes++;
        Debug.Log($"{nome} criou uma nova invenção. Total: {numeroDeInvecoes}");
    }
}


