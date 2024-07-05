package com.contravi.contravi.model;

import org.springframework.data.mongodb.core.mapping.Document;

@Document
public class Roteiro {
    
    private String saida;
    private String destino;
    private String chegada;

    public String getSaida() {
        return saida;
    }
    public void setSaida(String saida) {
        this.saida = saida;
    }
    public String getDestino() {
        return destino;
    }
    public void setDestino(String destino) {
        this.destino = destino;
    }
    public String getChegada() {
        return chegada;
    }
    public void setChegada(String chegada) {
        this.chegada = chegada;
    }

}
