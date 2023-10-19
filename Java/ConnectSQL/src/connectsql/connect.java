/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package connectsql;

import java.sql.*;

/**
 *
 * @author cacbu
 */
public class connect {

    public Connection getConnect() throws SQLException {
        String connectionUrl
                = "jdbc:sqlserver://NguyenHuyCuong:1433;"
                + "database=sinhvien;"
                + "user=sa;"
                + "password=123456;"
                + "encrypt=true;"
                + "trustServerCertificate=true;"
                + "loginTimeout=30;";
        Connection conn = DriverManager.getConnection(connectionUrl);
        return conn;
    }
}
