/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package connectsql;

/**
 *
 * @author cacbu
 */
public class sinhvien {

    private String mamon;
    private String tenmon;
    private String diem;

    public sinhvien() {
    }
    public sinhvien(String mamon, String tenmon, String diem) {
        this.mamon = mamon;
        this.tenmon = tenmon;
        this.diem = diem;
    }
    public String getMamon() {
        return this.mamon;
    }
    public String getTenmon() {
        return this.tenmon;
    }
    public String getDiem() {
        return this.diem;
    }
     public void setMamon(String mamon) {
        this.mamon = mamon;
    }
    public void setTenmon(String tenmon) {
      this.tenmon = tenmon;
    }
    public void setDiem(String diem) {
        this.diem = diem;
    }
    
}
