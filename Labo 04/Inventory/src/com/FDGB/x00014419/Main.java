//Debido a que solo se utilizara el main para comprobar, no se haran excepciones
package com.FDGB.x00014419;

import javax.swing.JOptionPane;
import java.util.ArrayList;

public class Main {
    private static ArrayList<Item> PersonalItems = new ArrayList<Item>();
    private static ArrayList<Item> CommonItems = new ArrayList<Item>();
    public static void main(String[] args) {
        byte option = 0;
        do{
            option = Byte.parseByte(JOptionPane.showInputDialog(null, menu()));
            switch (option){
                case 0:
                    break;
                case 1:
                    agregarItem();
                    break;
                case 2:
                    compartirItem();
                    break;
                case 3:
                    buscarItemID();
                    break;
                case 4:
                    buscarItemTipo();
                    break;
                case 5:
                    borrarID();
                    break;
                case 6:
                    borrarTipo();
                    break;
                default:
                    JOptionPane.showMessageDialog(null,"Opción inválida");
                    break;
            }
        }while(option!=0);
    }

    public static String menu(){
        return "MENU \n " +
                "1. Agregar ítem \n " +
                "2. Compartir ítem \n " +
                "3. Buscar ítem por ID \n " +
                "4. Buscar ítem por tipo \n " +
                "5. Borrar ítem por ID \n " +
                "6. Borrar ítem por tipo \n " +
                "0. Salir";
    }

    public static void agregarItem(){
        String item = "\0";
        item = JOptionPane.showInputDialog(null, "Digite el tipo de ítem (Potion, Elixir, " +
                "Ammo y Weapon)");
        if(item.equals("Potion")){
            int reuseTime = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el " +
                    "tiempo de reutilización del item de curación"));
            String level = JOptionPane.showInputDialog(null, "Digite el nivel del ítem de " +
                    "curación (Minor, Normal, Major)");
            String type = JOptionPane.showInputDialog(null, "Digite el tipo del ítem de " +
                    "curación (Mana, Life)");;
            int amount = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite la " +
                    "cantidad de la poción"));
            Potion nPotion = new Potion(reuseTime,level,type,amount);
            PersonalItems.add(nPotion);
        }
        else if(item.equals("Elixir")){
            int reuseTime = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el " +
                    "tiempo de reutilización del item de curación"));
            String level = JOptionPane.showInputDialog(null, "Digite el nivel del ítem de " +
                    "curación (Minor, Normal, Major)");
            String type = JOptionPane.showInputDialog(null, "Digite el tipo del ítem de " +
                    "curación (Mana, Life)");;
            int amount = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite la " +
                    "cantidad del elixir"));
            int time = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el " +
                    "tiempo del intervalo de curación"));
            Elixir nElixir = new Elixir(reuseTime,level,type,amount,time);
            PersonalItems.add(nElixir);
        }
        else if(item.equals("Ammo")){
            int remainingUses = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite " +
                    "los usos restantes"));
            byte equipped = Byte.parseByte(JOptionPane.showInputDialog(null, "1. Equipada\n" +
                    "2. No equipada"));
            if(equipped==1){
                Ammo nAmmo = new Ammo(remainingUses,true);
                PersonalItems.add(nAmmo);
            }
            else if(equipped==2){
                Ammo nAmmo = new Ammo(remainingUses,false);
                PersonalItems.add(nAmmo);
            }
            else{
                JOptionPane.showMessageDialog(null, "Opción inválida");
            }
        }
        else if(item.equals("Weapon")){
            int remainingUses = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite " +
                    "los usos restantes"));
            String type = JOptionPane.showInputDialog(null, "Digite el tipo de arma (Bow, " +
                    "Sword, Staff, Orb, Dagger)");
            double speed = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite la " +
                    "velocidad del arma"));;
            double damage = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite el " +
                    "daño que provoca el arma"));
            String wieldType = JOptionPane.showInputDialog(null, "Digite el tipo de " +
                    "empuñadura (One-Handed, Two-Handed)");
            int level = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el nivel " +
                    "del arma"));
            Weapon nWeapon = new Weapon(remainingUses,type,speed,damage,wieldType,level);
            PersonalItems.add(nWeapon);
        }
        else{
            JOptionPane.showMessageDialog(null,"El tipo de ítem no existe");
        }
    }

    public static void compartirItem(){
        int id = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el ID del item " +
                "que desea compartir"));
        PersonalItems.forEach((a)->{
            if(a.id==id){
                if(a instanceof  Potion){
                    Potion aux = new Potion(((Potion) a).reuseTime,((Potion) a).level,((Potion) a).type,((Potion) a).getAmount());
                    aux.setId(a.id);
                    CommonItems.add(aux);
                }
                else if(a instanceof  Elixir){
                    Elixir aux = new Elixir(((Elixir) a).reuseTime,((Elixir) a).level,((Elixir) a).type,((Elixir) a).getAmount(),((Elixir) a).getTime());
                    aux.setId(a.id);
                    CommonItems.add(aux);
                }
                else if(a instanceof  Ammo){
                    Ammo aux = new Ammo(((Ammo) a).remainingUses,((Ammo) a).isEquipped());
                    aux.setId(a.id);
                    CommonItems.add(aux);
                }
                else if(a instanceof Weapon){
                    Weapon aux = new Weapon(((Weapon) a).remainingUses,((Weapon) a).getType(),((Weapon) a).getSpeed(),((Weapon) a).getDamage(),((Weapon) a).getWieldType(),((Weapon) a).getLevel());
                    aux.setId(a.id);
                    CommonItems.add(aux);
                }
            }
        });
    }

    public static void buscarItemID(){
        byte opt = Byte.parseByte(JOptionPane.showInputDialog(null, "1. Buscar en " +
                "PersonalItems \n2. Buscar en CommonItems"));
        if(opt==1){
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el ID del " +
                    "item que desea encontrar en PersonalItems"));
            PersonalItems.forEach((a)->{
                if(a.id==id){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
            });
        }
        else if(opt==2){
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el ID del " +
                    "item que desea encontrar en CommonItems"));
            CommonItems.forEach((a)->{
                if(a.id==id){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
            });
        }
        else{
            JOptionPane.showMessageDialog(null,"Opción inválida");
        }
    }

    public static void buscarItemTipo(){
        byte opt = Byte.parseByte(JOptionPane.showInputDialog(null, "1. Buscar en" +
                " PersonalItems \n2. Buscar en CommonItems"));
        if(opt==1){
            String tipo = JOptionPane.showInputDialog(null, "Digite el tipo del item que " +
                    "desea encontrar en PersonalItems");
            PersonalItems.forEach((a)->{
                if(a instanceof  Potion && tipo.equals("Potion")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof  Elixir && tipo.equals("Elixir")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof  Ammo && tipo.equals("Ammo")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof Weapon && tipo.equals("Weapon")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
            });
        }
        else if(opt==2){
            String tipo = JOptionPane.showInputDialog(null, "Digite el tipo del item que" +
                    " desea encontrar en CommonItems");
            CommonItems.forEach((a)->{
                if(a instanceof  Potion && tipo.equals("Potion")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof  Elixir && tipo.equals("Elixir")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof  Ammo && tipo.equals("Ammo")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
                else if(a instanceof Weapon && tipo.equals("Weapon")){
                    JOptionPane.showMessageDialog(null,a.toString());
                }
            });
        }
        else{
            JOptionPane.showMessageDialog(null,"Opción inválida");
        }
    }

    public static void borrarID(){
        byte opt = Byte.parseByte(JOptionPane.showInputDialog(null, "1. Borrar en " +
                "PersonalItems \n2. Borrar en CommonItems"));
        if(opt==1){
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el ID del" +
                    " item que desea borrar de PersonalItems"));
            PersonalItems.removeIf((a)->a.id==id);
        }
        else if(opt==2){
            int id = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite el ID del " +
                    "item que desea borrar de CommonItems"));
            CommonItems.removeIf((a)->a.id==id);
        }
        else{
            JOptionPane.showMessageDialog(null,"Opción inválida");
        }
    }

    public static void borrarTipo(){
        byte opt = Byte.parseByte(JOptionPane.showInputDialog(null, "1. Borrar en" +
                " PersonalItems \n2. Borrar en CommonItems"));
        if(opt==1){
            String tipo = JOptionPane.showInputDialog(null, "Digite el tipo del item que desea" +
                    " borrar de PersonalItems");
            if(tipo.equals("Potion")){
                PersonalItems.removeIf((a)->a instanceof Potion);
            }
            else if(tipo.equals("Elixir")){
                PersonalItems.removeIf((a)->a instanceof Elixir);
            }
            else if(tipo.equals("Weapon")){
                PersonalItems.removeIf((a)->a instanceof Weapon);
            }
            else if(tipo.equals("Ammo")){
                PersonalItems.removeIf((a)->a instanceof Ammo);
            }
            else{
                JOptionPane.showMessageDialog(null,"Tipo inválido");
            }
        }
        else if(opt==2){
            String tipo = JOptionPane.showInputDialog(null, "Digite el tipo del item que desea" +
                    " borrar de CommonItems");
            if(tipo.equals("Potion")){
                CommonItems.removeIf((a)->a instanceof Potion);
            }
            else if(tipo.equals("Elixir")){
                CommonItems.removeIf((a)->a instanceof Elixir);
            }
            else if(tipo.equals("Weapon")){
                CommonItems.removeIf((a)->a instanceof Weapon);
            }
            else if(tipo.equals("Ammo")){
                CommonItems.removeIf((a)->a instanceof Ammo);
            }
            else{
                JOptionPane.showMessageDialog(null,"Tipo inválido");
            }
        }
        else{
            JOptionPane.showMessageDialog(null,"Opción inválida");
        }
    }
}
