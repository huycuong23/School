/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package connectsql;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author cacbu
 */
public class getsv {
    Connection conn = null;
    PreparedStatement ps = null;
    ResultSet rs = null;

    public List<sinhvien> getAllSinhVien() throws SQLException {
        List<sinhvien> List =new ArrayList<>();    
        String sql = "select * from diem";
        try {
            conn = new connect().getConnect();
            ps = conn.prepareStatement(sql);
            rs = ps.executeQuery();
            while (rs.next()) {
               List.add(new sinhvien(rs.getString(1), rs.getString(2), rs.getString(3)));
            }
        } catch (SQLException e) {
        }
        return List;
    }
    
    
}
