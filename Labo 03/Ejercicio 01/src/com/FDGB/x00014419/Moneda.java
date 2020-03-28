package com.FDGB.x00014419;

public class Moneda {
    private String moneda = "\0";
    private float valor = 0.00f;

    public void Moneda(String moneda) {
        this.moneda = moneda;
        valor = Float.parseFloat(moneda.substring(1,5));
    }

    public float getValor() {
        return valor;
    }

    public static void requirements(String USD){
        if(USD.equals("$0.05 USD") || USD.equals("$0.10 USD") ||USD.equals("$0.25 USD") ||USD.equals("$1.00 USD")){
        }
        else{
            throw new IllegalArgumentException("La moneda ingresada no es valida");
        }
    }
}