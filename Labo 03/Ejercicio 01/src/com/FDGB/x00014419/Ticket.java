package com.FDGB.x00014419;

import javax.swing.JOptionPane;
import java.time.LocalTime;

public class Ticket {
    private RegistroDeTiempo tiempo;
    private Automóvil auto;
    private boolean estadoPagado = false;
    private float vuelto = 0.00f;

    public Ticket(String placa, LocalTime horaEntrada) {
        tiempo = new RegistroDeTiempo(horaEntrada);
        auto = new Automóvil(placa);
    }

    public String getPlaca() {
        return auto.getPlaca();
    }

    public void setHoraSalida(LocalTime horaSalida) {
        tiempo.setHoraSalida(horaSalida);
    }

    public boolean seguirPagando(float a,float b){
        if(a<b){
            estadoPagado = false;
            return true;
        }
        else{
            estadoPagado = true;
            return false;
        }
    }

    public void devolverDinero(float a,float b){
        vuelto=a-b;
    }

    public void pagar(){
        Moneda dinero = new Moneda();
        String pasta = "\0";
        float pagado= 0.00f;
        do{
            pasta = JOptionPane.showInputDialog(null, "Digite la moneda: ($0.05 USD, $0.10 USD, $0.25 USD y $1.00 USD)");
            Moneda.requirements(pasta);
            dinero.Moneda(pasta);
            pagado+=dinero.getValor();
        }while (seguirPagando(pagado,tiempo.getCantidadPagar()));
        devolverDinero(pagado,tiempo.getCantidadPagar());
    }

    @Override
    public String toString() {
        String frase;
        LocalTime aux = LocalTime.of(0,0,0);
        frase = "Ticket\n" +
                "Placa: " + auto.getPlaca() + '\n' +
                "Hora de Entrada: " + tiempo.getHoraEntrada() + '\n';
        if(!(tiempo.getHoraSalida().compareTo(LocalTime.parse("00:00:00"))==0)){
            frase += "Hora de Salida: " + tiempo.getHoraSalida() + '\n';
            if(!estadoPagado){
                frase += "Cantidad a pagar: $" + tiempo.getCantidadPagar() + " USD" +'\n';
            }
            else{
                frase += "Cantidad a devolver: $" + vuelto + " USD" +'\n';
            }
        }
        if(estadoPagado==true){
            frase += "Estado: PAGADO";
        }
        else{
            frase += "Estado: NO PAGADO";
        }
        return frase;
    }
}
