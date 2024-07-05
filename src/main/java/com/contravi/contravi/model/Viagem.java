package com.contravi.contravi.model;

import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.DBRef;
import org.springframework.data.mongodb.core.mapping.Document;

import java.time.LocalDateTime;
import java.util.List;

@Document
public class Viagem {
    @Id
    private String id;

    @DBRef
    private Motorista motorista;

    @DBRef
    private Veiculo veiculo;

    @DBRef
    private List<DestinoDoPassageiro> destinoDosPassageiros;

    @DBRef
    private Roteiro roteiro;

    private LocalDateTime horarioDaViagem;
    private LocalDateTime dataDaViagem;
    
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Motorista getMotorista() {
        return motorista;
    }

    public void setMotorista(Motorista motorista) {
        this.motorista = motorista;
    }

    public Veiculo getVeiculo() {
        return veiculo;
    }

    public void setVeiculo(Veiculo veiculo) {
        this.veiculo = veiculo;
    }

    public LocalDateTime getHorarioDaViagem() {
        return horarioDaViagem;
    }

    public void setHorarioDaViagem(LocalDateTime horarioDaViagem) {
        this.horarioDaViagem = horarioDaViagem;
    }

    public LocalDateTime getDataDaViagem() {
        return dataDaViagem;
    }

    public void setDataDaViagem(LocalDateTime dataDaViagem) {
        this.dataDaViagem = dataDaViagem;
    }

    public Roteiro getRoteiro() {
        return roteiro;
    }

    public void setRoteiro(Roteiro roteiro) {
        this.roteiro = roteiro;
    }
}
