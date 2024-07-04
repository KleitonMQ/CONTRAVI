package com.contravi.contravi.model;

import org.springframework.data.mongodb.core.mapping.Document;

@Document
public class Motorista extends Pessoa {
    private String CNH;

    // Getters and Setters
    public String getCNH() {
        return CNH;
    }

    public void setCNH(String CNH) {
        this.CNH = CNH;
    }
}
