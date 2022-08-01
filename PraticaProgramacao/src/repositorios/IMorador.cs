﻿using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios
{
    public interface IMorador
    {
         Task NovoMoradorAsync(NovoMoradorDTO Morador);
         Task AtualizarMoradorAsync(AtualizarMoradorDTO Morador);
         Task DeletarMoradorAsync(int id);
         Task<MoradorModelo> PegarPeloIdAsync(int id);
         Task<List<MoradorModelo>> PegarPeloNomeAsync(string nome);
         Task<List<MoradorModelo>> PegarPeloIdadeAsync(string idade);
    }
}
