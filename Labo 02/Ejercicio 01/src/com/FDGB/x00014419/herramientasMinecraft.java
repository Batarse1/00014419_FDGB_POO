package com.FDGB.x00014419;

public class herramientasMinecraft {
    //Atributos
    private String name;
    private String type;
    private String mineral;
    private float damage;
    private int durability;
    private float attackSpeed;

    //Constructor
    public herramientasMinecraft(String name, String type, String mineral, float damage, int durability, float attackSpeed) {
        this.name = name;
        this.type = type;
        this.mineral = mineral;
        this.damage = damage;
        this.durability = durability;
        this.attackSpeed = attackSpeed;
    }

    //Atacar criatura o jugador (sin pociones, encantamientos o golpes criticos)
    public double attack(int ticksSinceLastAttack){
        float T = 1 / attackSpeed * 20 ;
        double multiplier = 0.2 + ( Math.pow ( ( ( ticksSinceLastAttack + 0.5 ) / T ) , 2 ) ) * 0.8;
        if(multiplier>1){
            multiplier=1.0;
        }
        if(type.equals("Sword") || type.equals("Hoe")){
            durability--;
        }
        else if(type.equals("Pickaxe") || type.equals("Axe") || type.equals("Shovel")){
            durability-=2;
        }
        return damage*multiplier;
    }

    //Etiquetar
    public void tagTool(String name) {
        this.name = name;
    }

    public String getType() {
        return type;
    }

    @Override
    public String toString() {
        return "herramientasMinecraft{" +
                "nombre='" + name + '\'' +
                ", tipo='" + type + '\'' +
                ", mineral='" + mineral + '\'' +
                ", daño=" + damage +
                ", durabilidad=" + durability +
                ", velocidad de ataque=" + attackSpeed +
                '}';
    }
}