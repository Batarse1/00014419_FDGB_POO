package com.FDGB.x00014419;

import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        String frase="\0";
        String frase_modificada="\0";
        Scanner scan=new Scanner(System.in);
        System.out.print("Digite la frase que quiera encriptar: ");
        frase=scan.nextLine();
        frase_modificada=frase.replace('a','b');
        System.out.println("Frase encriptada: " + frase_modificada);
    }
}