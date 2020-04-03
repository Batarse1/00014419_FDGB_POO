package com.FDGB.x00014419;

abstract class HealthItem extends Item{
    protected int reuseTime = 0;
    protected String level = "\0";
    protected String type = "\0";

    public HealthItem(int reuseTime, String level, String type) {
        this.reuseTime = reuseTime;
        this.level = level;
        this.type = type;
    }

    public HealthItem(String name, int weight, String description, int reuseTime, String level, String type) {
        super(name, weight, description);
        this.reuseTime = reuseTime;
        this.level = level;
        this.type = type;
    }

    abstract void drink();
}