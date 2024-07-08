package com.contravi.contravi.service;

import org.springframework.stereotype.Service;

import com.contravi.contravi.model.Motorista;
import com.contravi.contravi.model.Viagem;

import java.time.LocalDateTime;
import java.util.List;

@Service
public interface ViagemService {

    public List<Viagem> listarTodas();

    public Viagem salvar(Viagem viagem);

    public void deletarPorId(String id);

    public Viagem buscarPorId(String id);

    public List<Viagem> buscarPorData(LocalDateTime dataDaViagem);

    public List<Viagem> buscarPorMotorista(Motorista motorista);

    public List<Viagem> buscarPorMotoristaEData(String motoristaId, LocalDateTime dataDaViagem);
}
