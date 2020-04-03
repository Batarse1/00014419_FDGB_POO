package com.FDGB.x00014419;

abstract class Item {
    protected int id = 0;
    protected String name = "\0";
    protected int weight = 0;
    protected String description = "\0";

    public Item() {
        this.id = IdGenerator.newId();
    }

    public void setId(int id) {
        this.id = id;
    }

    public Item(String name, int weight, String description) {
        this.id = IdGenerator.newId();
        this.name = name;
        this.weight = weight;
        this.description = description;
    }

    @Override
    public String toString() {
        return "Item{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", weight=" + weight +
                ", description='" + description + '\'' +
                '}';
    }
}