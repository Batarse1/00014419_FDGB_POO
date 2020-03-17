package com.FDGB.x00014419;

import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        int n=0;
        int aux1=1;
        int aux2=0;
        int r=0;
        Scanner scan=new Scanner(System.in);
        System.out.print("Digite hasta que n termino quiere llegar en la sucesion de fibonacci: ");
        n=scan.nextInt();scan.nextLine();
        for(int i=0;i<n;i++){
            if(i==0){
                r=0;
            }
            else if(i==1 && i==2){
                r=1;
            }
            else{
                aux2=aux1;
                aux1=r;
                r=aux1+aux2;
            }
            System.out.println(r);
        }
    }
}