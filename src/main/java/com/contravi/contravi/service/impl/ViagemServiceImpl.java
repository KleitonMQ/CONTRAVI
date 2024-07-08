package com.contravi.contravi.service.impl;

import java.time.LocalDateTime;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;

import com.contravi.contravi.model.Motorista;
import com.contravi.contravi.model.Viagem;
import com.contravi.contravi.repository.ViagemRepository;
import com.contravi.contravi.service.ViagemService;

public class ViagemServiceImpl implements ViagemService{

    
    @Autowired
    private ViagemRepository viagemRepository;

    @Override
    public List<Viagem> listarTodas() {
        return viagemRepository.findAll();
    }

    @Override
    public Viagem salvar(Viagem viagem) {
        return viagemRepository.save(viagem);
    }

    @Override
    public void deletarPorId(String id) {
        viagemRepository.deleteById(id);
    }

    @Override
    public Viagem buscarPorId(String id) {
        return viagemRepository.findById(id).orElse(null);
    }

    @Override
    public List<Viagem> buscarPorData(LocalDateTime dataDaViagem) {
        return viagemRepository.findByDataDaViagem(dataDaViagem);
    }

    @Override
    public List<Viagem> buscarPorMotorista(Motorista motorista) {
        return viagemRepository.findByMotorista(motorista);
    }

    @Override
    public List<Viagem> buscarPorMotoristaEData(String motoristaId, LocalDateTime dataDaViagem) {
        return viagemRepository.findByMotoristaIdAndDataDaViagem(motoristaId, dataDaViagem);
    }
}
