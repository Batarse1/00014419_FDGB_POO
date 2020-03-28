package com.FDGB.x00014419;

import javax.swing.JOptionPane;
import java.util.ArrayList;
import java.time.LocalTime;

public class Main {

    public static void main(String[] args) {

        ArrayList<Ticket> lista_tickets = new ArrayList<>();

        byte option = 0;
        String placa = "\0";
        LocalTime horaEntrada = LocalTime.parse("00:00:00");
        LocalTime horaSalida = LocalTime.parse("00:00:00");
        int cont = 0;
        int contAux = 0;

        do{
            option = Byte.parseByte(JOptionPane.showInputDialog(null, menu()));
            switch (option){
                case 1:
                    placa = JOptionPane.showInputDialog(null, "Digite la placa");
                    for(Ticket a: lista_tickets){
                        if(a.getPlaca().equals(placa)){
                            throw new IllegalArgumentException("La placa ya existe");
                        }
                    }
                    horaEntrada = LocalTime.parse(JOptionPane.showInputDialog(null, "Digite la hora de entrada en formato (00:00:00)"));
                    lista_tickets.add(new Ticket(placa,horaEntrada));
                    break;
                case 2:
                    boolean bandera1=false;
                    placa = JOptionPane.showInputDialog(null, "Digite la placa del ticket que quiere eliminar");
                    cont=0;
                    for(Ticket a: lista_tickets){
                        if(a.getPlaca().equals(placa)){
                            bandera1 = true;
                            horaSalida = LocalTime.parse(JOptionPane.showInputDialog(null, "Digite la hora de salida en formato (00:00:00)"));
                            a.setHoraSalida(horaSalida);
                            JOptionPane.showMessageDialog(null,a.toString());
                            a.pagar();
                            JOptionPane.showMessageDialog(null,a.toString());
                            contAux=cont;
                        }
                        cont++;
                    }
                    if(bandera1==false){
                        JOptionPane.showMessageDialog(null,"El ticket no existe");
                    }
                    else{
                        lista_tickets.remove(contAux);
                    }
                    break;
                case 3:
                    boolean bandera2 = false;
                    placa = JOptionPane.showInputDialog(null, "Digite la placa del ticket que quiere consultar");
                    for(Ticket a: lista_tickets){
                        if(a.getPlaca().equals(placa)){
                            bandera2 = true;
                            JOptionPane.showMessageDialog(null,a.toString());
                        }
                    }
                    if(bandera2==false){
                        JOptionPane.showMessageDialog(null,"El ticket no existe");
                    }
                    break;
                case 4:
                    break;
                default:
                    JOptionPane.showMessageDialog(null,"Opción invalida...");
                    break;
            }
        }while(option!=4);

	}

    public static String menu(){
        return "MENU \n " +
                "1. Ingresar automóvil \n " +
                "2. Salir del parqueo \n " +
                "3. Consultar ticket \n " +
                "4. Salir";
    }

}
