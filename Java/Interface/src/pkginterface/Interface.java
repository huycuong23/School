/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pkginterface;
/**
 *
 * @author cacbu
 */
public class Interface implements interface2 {

    @Override
    public void print() {
        System.out.println("interface class");
    }
    public static void main(String[] args) {
        Interface a = new Interface();
        a.print();
    }
    
}
