package com.FDGB.x00014419;

import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        int n=0;
        Scanner scan=new Scanner(System.in);
        System.out.print("Digite el termino n: ");
        n=scan.nextInt();
        secuencia(0,n);
    }
    public static void secuencia(int cont,int n){
        if(n==cont){
        }
        else if(n-1==cont){
            cont++;
            System.out.println(cont);
        }
        else{
            cont++;
            System.out.println(cont);
            secuencia(cont,n);
            System.out.println(cont);
        }
    }
}