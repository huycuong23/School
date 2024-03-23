/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package bai1;

/**
 *
 * @author cacbu
 */
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Bai1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int[] a = new int[6];
        int tong = 0;
        int max = a[0];

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        try {
            System.out.println("Nhập mảng số nguyên gồm 6 phần tử, cách nhau bởi dấu phẩy:");
            String input = reader.readLine(); // Đọc dữ liệu từ người dùng
            String[] elements = input.split(","); // Phân tách chuỗi thành các phần tử

            // Chuyển đổi và lưu các phần tử vào mảng
            for (int i = 0; i < elements.length; i++) {
                a[i] = Integer.parseInt(elements[i].trim());
            }

            // In ra mảng đã nhập
            System.out.print("Mảng a: ");
            for (int i = 0; i < a.length; i++) {
                if (a[i] > max) {
                    max = a[i];
                }
                tong = tong + a[i];
            }
            System.out.println("Tong cua mang la: " + tong);
            System.out.println("Gia tri lon nhat la: " + max);

        } catch (IOException e) {
        } catch (NumberFormatException e) {
            System.out.println("Định dạng đầu vào không hợp lệ!");
        }
    }
}
