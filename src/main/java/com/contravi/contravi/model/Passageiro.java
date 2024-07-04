package com.contravi.contravi.model;

import org.springframework.data.mongodb.core.mapping.Document;

@Document
public class Passageiro extends Pessoa {
    private String CNS;

    // Getters and Setters
    public String getCNS() {
        return CNS;
    }

    public void setCNS(String CNS) {
        this.CNS = CNS;
    }
}
