package com.contravi.contravi.model;

import org.springframework.data.mongodb.core.mapping.DBRef;
import org.springframework.data.mongodb.core.mapping.Document;

import java.time.LocalDateTime;

@Document
public class DestinoDoPassageiro {

    @DBRef
    private Passageiro passageiro;

    private String procedimento;
    private String destino;
    private LocalDateTime horarioDeAtendimento;


    public Passageiro getPassageiros() {
        return passageiro;
    }

    public void setPassageiros(Passageiro passageiro) {
        this.passageiro = passageiro;
    }
    
    public String getProcedimento() {
        return procedimento;
    }

    public void setProcedimento(String procedimento) {
        this.procedimento = procedimento;
    }

    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) {
        this.destino = destino;
    }

    public LocalDateTime getHorarioDeAtendimento() {
        return horarioDeAtendimento;
    }

    public void setHorarioDeAtendimento(LocalDateTime horarioDeAtendimento) {
        this.horarioDeAtendimento = horarioDeAtendimento;
    }
}
