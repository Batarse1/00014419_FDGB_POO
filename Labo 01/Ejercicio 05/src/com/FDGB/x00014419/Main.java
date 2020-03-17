package com.FDGB.x00014419;

import java.util.ArrayList;
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        ArrayList<Character> list = new ArrayList<>();
        Scanner scan = new Scanner(System.in);
        int n=0;
        char c='\0';
        System.out.print("Digite cuantos letras quiere ingresar: ");
        n=scan.nextInt();scan.nextLine();
        for(int i=0;i<n;i++){
            c=scan.next().charAt(0);scan.nextLine();
            if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u' || c=='A' || c=='E' || c=='I' || c=='O' || c=='U'){
                list.add(c);
            }
        }
        System.out.println("Las vocales que se ingresaron fueron las siguientes: " + list);
    }
}