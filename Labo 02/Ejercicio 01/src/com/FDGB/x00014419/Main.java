package com.FDGB.x00014419;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    private static void menu(){
        System.out.println("1. Agregar herramienta a la lista");
        System.out.println("2. Consultar herramientas (todas)");
        System.out.println("3. Consultar herramientas de un tipo");
        System.out.println("4. Atacar criatura o jugador (sin pociones, encantamientos o golpes criticos)");
        System.out.println("5. Etiquetar herramienta");
        System.out.println("6. Salir");
    }
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        ArrayList<herramientasMinecraft> lista_herramientas = new ArrayList<>();
        byte option = 0;
        do{
            menu();
            option = scan.nextByte();scan.nextLine();
            switch (option){
                case 1:
                    System.out.printf("Nombre de la herramienta: ");
                    String name = scan.nextLine();
                    String type="\0";
                    do{
                        System.out.printf("Tipo de herramienta (Sword, Pickaxe, Axe, Shovel, Hoe): ");
                        type = scan.nextLine();
                        if(!(type.equals("Sword") || type.equals("Pickaxe") || type.equals("Axe") || type.equals("Shovel") || type.equals("Hoe"))){
                            System.out.println("Tipo de herramienta incorrecta");
                        }
                    }while(!(type.equals("Sword") || type.equals("Pickaxe") || type.equals("Axe") || type.equals("Shovel") || type.equals("Hoe")));
                    String mineral = "\0";
                    do{
                        System.out.printf("Tipo de mineral (Wood, Stone, Gold, Iron, Diamond, Netherite): ");
                        mineral = scan.nextLine();
                        if(!(mineral.equals("Wood") || mineral.equals("Stone") || mineral.equals("Gold") || mineral.equals("Iron") || mineral.equals("Diamond") || mineral.equals("Netherite"))){
                            System.out.println("Tipo de mineral incorrecto");
                        }
                    }while(!(mineral.equals("Wood") || mineral.equals("Stone") || mineral.equals("Gold") || mineral.equals("Iron") || mineral.equals("Diamond") || mineral.equals("Netherite")));
                    System.out.printf("Daño: ");
                    float damage = scan.nextFloat();scan.nextLine();
                    System.out.printf("Durabilidad: ");
                    int durability = scan.nextShort();scan.nextLine();
                    System.out.printf("Velocidad de ataque: ");
                    float attackSpeed = scan.nextFloat();scan.nextLine();
                    lista_herramientas.add(new herramientasMinecraft(name,type,mineral,damage,durability,attackSpeed));
                    break;
                case 2:
                    System.out.println("LISTA DE HERRAMIENTAS");
                    lista_herramientas.forEach((a)->System.out.println(a.toString()));
                    break;
                case 3:
                    String aux = "\0";
                    do{
                        System.out.print("Digitar el tipo de herramientas que quiere consultar:");
                        aux = scan.nextLine();
                        if(!(aux.equals("Sword") || aux.equals("Pickaxe") || aux.equals("Axe") || aux.equals("Shovel") || aux.equals("Hoe"))){
                            System.out.println("Tipo de herramienta incorrecta");
                        }
                    }while(!(aux.equals("Sword") || aux.equals("Pickaxe") || aux.equals("Axe") || aux.equals("Shovel") || aux.equals("Hoe")));
                    String typeLooking = aux;
                    lista_herramientas.forEach((a)->
                    {
                        if(a.getType().equals(typeLooking)){
                            System.out.println(a.toString());
                        }
                    });
                    break;
                case 4:
                    lista_herramientas.forEach((a)-> {
                        System.out.printf("Con la herramienta: ");
                        System.out.println(a.toString());
                        System.out.println("Se realizó " + a.attack(32) + " de daño");
                    });
                    break;
                case 5:
                    lista_herramientas.forEach((a)->{
                        System.out.printf("Nombre que le desea poner a la herramienta: ");
                        System.out.println(a.toString());
                        String new_name = scan.nextLine();
                        a.tagTool(new_name);
                        System.out.printf("Nuevos datos de la herramienta: ");
                        System.out.println(a.toString());
                    });
                    break;
                case 6:
                    break;
                default:
                    System.out.println("Opcion incorrecta");
                    break;
            }
        }while(option!=6);
    }

}
