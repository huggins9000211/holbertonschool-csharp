﻿using System;

enum Rating {Good, Great, Excellent}
struct Dog 
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string n, float a, string o, Rating r)
    {
        this.name = n;
        this.age = a;
        this.owner = o;
        this.rating = r;
    }

    public override string ToString()
    {
        return ($"Dog Name: {this.name}\nAge: {this.age}\nOwner: {this.owner}\nRating: {this.rating}");
    }
}