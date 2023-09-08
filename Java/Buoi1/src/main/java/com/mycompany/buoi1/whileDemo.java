/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi1;

/**
 *
 * @author cacbu
 */
public class whileDemo {
    public static void main(String args[]) {
        int a=5,fact=1;
        while(a>=1) {
            fact*=a;
            a--;
        }
        System.out.println("The factorial of 5 is "+fact);
    }
}
