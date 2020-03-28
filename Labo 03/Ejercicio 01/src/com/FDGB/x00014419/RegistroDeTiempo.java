package com.FDGB.x00014419;

import java.time.LocalTime;
import static java.time.temporal.ChronoUnit.MINUTES;

public class RegistroDeTiempo {
    private LocalTime horaEntrada = LocalTime.parse("00:00:00");
    private LocalTime horaSalida = LocalTime.parse("00:00:00");
    private int difference = 0;
    private float cantidadPagar = 0.00f;

    public RegistroDeTiempo(LocalTime horaEntrada) {
        this.horaEntrada = horaEntrada;
    }

    public void cantidadPagar(){
        difference = (int) MINUTES.between(horaEntrada,horaSalida);
        if(difference<30){
            cantidadPagar = 0.50f;
        }
        else if(difference<60){
            cantidadPagar = 1.00f;
        }
        else if(difference<120){
            cantidadPagar = 2.00f;
        }
        else{
            cantidadPagar = 5.00f;
        }
    }

    public void Requirements(LocalTime nuevaHoraSalida){
        if(nuevaHoraSalida.compareTo(horaEntrada)>0){
        }
        else{
            throw new IllegalArgumentException("La hora de salida es menor o igual a la hora de entrada");
        }
    }

    public void setHoraSalida(LocalTime nuevaHoraSalida) {
        Requirements(nuevaHoraSalida);
        this.horaSalida = nuevaHoraSalida;
        cantidadPagar();
    }

    public LocalTime getHoraEntrada() {
        return horaEntrada;
    }

    public LocalTime getHoraSalida() {
        return horaSalida;
    }

    public float getCantidadPagar() {
        return cantidadPagar;
    }
}