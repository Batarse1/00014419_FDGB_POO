package com.FDGB.x00014419;

import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        String frase="\0";
        boolean palindrome=true;
        int aux=0;
        Scanner scan=new Scanner(System.in);
        System.out.print("Digite la frase que quiere comprobar si es palindrome: ");
        frase=scan.nextLine();
        aux=frase.length();
        for(int i=0;i<frase.length();i++){
            aux--;
            if(frase.charAt(i)==' ' && frase.charAt(aux)==' '){
            }
            else if(frase.charAt(i)==' '){
                aux++;
            }
            else if(frase.charAt(aux)==' '){
                i--;
            }
            else if(frase.charAt(i)!=frase.charAt(aux)){
                palindrome=false;
            }
        }
        if(palindrome==true){
            System.out.println("La palabra es palindrome");
        }
        else{
            System.out.println("La palabra no es palindrome");
        }
    }
}