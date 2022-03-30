
import java.awt.BorderLayout;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.ResultSet;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JPanel.java to edit this template
 */

/**
 *
 * @author 84978
 */
public class ThemMoiSanPham extends javax.swing.JPanel {

    private String MaSP ="";
    private String TenSP ="";
    private String Mota = "";
    private long GiaGoc = 0;
    private int PhanTramGiamGia = 0;
    private String MaDM ="";
    private String MaNCC = "";
    /**
     * Creates new form ThemMoiSanPham
     */
    public ThemMoiSanPham() {
        initComponents();
        String MaSP = new Helper().TaoMaSanPhamNgauNhienKhongTrungLap();
        LoadMaDMCBox();
        LoadMaNCCCBox();
        MaSPTxt.setText(MaSP);
    }
    public String getMaSP(){
        return MaSPTxt.getText();
    }
    public String getTenSP(){
        return TenSPTxt.getText();
    }
    public String getMoTa(){
        return MotaTxt.getText();
    }
    public String getGiaGoc(){
        return GiaGocTxt.getText();
    }
    public String getPhanTram(){
        return (PhanTramGiamGiaTxt.getText());
    }
    public String getMaDM(){
        return (String)MaDMCBox.getSelectedItem();
    }
    public String getMaNCC(){
        return (String)MaNCCCBox.getSelectedItem();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        MaSPTxt = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        TenSPTxt = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        MotaTxt = new javax.swing.JTextArea();
        jLabel4 = new javax.swing.JLabel();
        GiaGocTxt = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        PhanTramGiamGiaTxt = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        ThemDMBtn = new javax.swing.JButton();
        ThemNCCBtn = new javax.swing.JButton();
        MaDMCBox = new javax.swing.JComboBox<>();
        MaNCCCBox = new javax.swing.JComboBox<>();

        setBackground(new java.awt.Color(31, 34, 46));
        setPreferredSize(new java.awt.Dimension(1200, 365));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 255, 255));
        jLabel1.setText("Mã sản phẩm");

        MaSPTxt.setEditable(false);
        MaSPTxt.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 255, 255));
        jLabel2.setText("Tên sản phẩm");

        TenSPTxt.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("Mô tả");

        MotaTxt.setColumns(20);
        MotaTxt.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        MotaTxt.setRows(5);
        jScrollPane2.setViewportView(MotaTxt);

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(255, 255, 255));
        jLabel4.setText("Giá gốc");

        GiaGocTxt.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        GiaGocTxt.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                GiaGocTxtKeyTyped(evt);
            }
        });

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 255, 255));
        jLabel5.setText("Phần trăm giảm giá");

        PhanTramGiamGiaTxt.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        PhanTramGiamGiaTxt.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                PhanTramGiamGiaTxtKeyTyped(evt);
            }
        });

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(255, 255, 255));
        jLabel6.setText("Mã danh mục");

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(255, 255, 255));
        jLabel7.setText("Mã nhà cung cấp");

        ThemDMBtn.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        ThemDMBtn.setText("Thêm");
        ThemDMBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ThemDMBtnMouseClicked(evt);
            }
        });

        ThemNCCBtn.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        ThemNCCBtn.setText("Thêm ");
        ThemNCCBtn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ThemNCCBtnMouseClicked(evt);
            }
        });

        MaDMCBox.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N

        MaNCCCBox.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        MaNCCCBox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                MaNCCCBoxActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(51, 51, 51)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2)
                    .addComponent(jLabel3))
                .addGap(38, 38, 38)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(MaSPTxt, javax.swing.GroupLayout.DEFAULT_SIZE, 289, Short.MAX_VALUE)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 289, Short.MAX_VALUE)
                    .addComponent(TenSPTxt))
                .addGap(124, 124, 124)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel5)
                    .addComponent(jLabel6)
                    .addComponent(jLabel4)
                    .addComponent(jLabel7))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 27, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(GiaGocTxt)
                            .addComponent(MaDMCBox, 0, 289, Short.MAX_VALUE)
                            .addComponent(PhanTramGiamGiaTxt))
                        .addGap(49, 49, 49)
                        .addComponent(ThemDMBtn))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(MaNCCCBox, javax.swing.GroupLayout.PREFERRED_SIZE, 289, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 45, Short.MAX_VALUE)
                        .addComponent(ThemNCCBtn)))
                .addGap(32, 32, 32))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(43, 43, 43)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(MaSPTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4)
                    .addComponent(GiaGocTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(37, 37, 37)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(TenSPTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5)
                    .addComponent(PhanTramGiamGiaTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(36, 36, 36)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel3, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel6)
                            .addComponent(ThemDMBtn)
                            .addComponent(MaDMCBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(36, 36, 36)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(MaNCCCBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel7)
                            .addComponent(ThemNCCBtn))))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void ThemDMBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ThemDMBtnMouseClicked
        ThemMoiDanhMuc tmdm = new ThemMoiDanhMuc();
        JPanel jp = new JPanel();
        jp.setPreferredSize(new java.awt.Dimension(500, 40));
        jp.setBackground(new java.awt.Color(31,34,46));
        JButton OKBtn = new JButton("OK");
        OKBtn.setFont(new Font("Tahoma", Font.BOLD,14));
        OKBtn.setPreferredSize(new java.awt.Dimension(97, 25));
        JButton CacelBtn = new JButton("Huỷ");
        CacelBtn.setFont(new Font("Tahoma", Font.BOLD,14));
        CacelBtn.setPreferredSize(new java.awt.Dimension(97, 25));
        jp.add(OKBtn);
        jp.add(CacelBtn);
        JDialog dialog = new JDialog();
        OKBtn.addActionListener(new ActionListener() { 
                          public void actionPerformed(ActionEvent e) {
                              String MaDM = tmdm.LayMaDM();
                              String TenDM = tmdm.LayTenDM();
                              if(TenDM.equals("")){
                                  JOptionPane.showMessageDialog(dialog, "Nhập tên danh mục");
                              }
                              else{
                                  if(!(new DBUpdater().ThemMoiDanhMuc(MaDM, TenDM))){
                                        JOptionPane.showMessageDialog(dialog, "Lỗi");
                                        dialog.dispose();
                                    }
                                    else{
                                        LoadMaDMCBox();
                                        MaDMCBox.setSelectedItem((MaDM));
                                        JOptionPane.showMessageDialog(dialog, "Thêm thành công");
                                        dialog.dispose();
                                    }
                              }
                                  
                          }  
                                 
                                                         
                        });
        CacelBtn.addActionListener(new ActionListener() { 
                          public void actionPerformed(ActionEvent e) { 
                              dialog.dispose();
                          }
                        });
        dialog.getContentPane().setLayout(new BorderLayout());
        dialog.getContentPane( ).add(tmdm, BorderLayout.CENTER);
        dialog.getContentPane( ).add(jp, BorderLayout.SOUTH);
        dialog.setModal(true);
        dialog.pack();
        dialog.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        dialog.setLocationRelativeTo(null);
        
        dialog.setVisible(true);
        dialog.addWindowListener(new WindowAdapter()
        {
            public void windowClosing (WindowEvent e)
            {
                super.windowClosing(e);
            }
        });
    }//GEN-LAST:event_ThemDMBtnMouseClicked

    private void MaNCCCBoxActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_MaNCCCBoxActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_MaNCCCBoxActionPerformed

    private void ThemNCCBtnMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ThemNCCBtnMouseClicked
        ThemMoiNhaCungCap tmncc = new ThemMoiNhaCungCap();
        JPanel jp = new JPanel();
        jp.setPreferredSize(new java.awt.Dimension(500, 40));
        jp.setBackground(new java.awt.Color(31,34,46));
        JButton OKBtn = new JButton("OK");
        OKBtn.setFont(new Font("Tahoma", Font.BOLD,14));
        OKBtn.setPreferredSize(new java.awt.Dimension(97, 25));
        JButton CacelBtn = new JButton("Huỷ");
        CacelBtn.setFont(new Font("Tahoma", Font.BOLD,14));
        CacelBtn.setPreferredSize(new java.awt.Dimension(97, 25));
        jp.add(OKBtn);
        jp.add(CacelBtn);
        JDialog dialog = new JDialog();
        OKBtn.addActionListener(new ActionListener() { 
                          public void actionPerformed(ActionEvent e) { 
                              String MaNCC = tmncc.getMaNCC();
                              String TenNCC = tmncc.getTenNCC();
                              if(TenNCC.equals("")){
                                  JOptionPane.showMessageDialog(dialog, "Nhập tên nhà cung cấp");
                              }
                              else{
                                    if(!(new DBUpdater().ThemMoiNhaCungCap(MaNCC, TenNCC))){
                                        JOptionPane.showMessageDialog(dialog, "Lỗi");
                                        dialog.dispose();
                                    }
                                    else{
                                        LoadMaNCCCBox();
                                        MaNCCCBox.setSelectedItem((MaNCC));
                                        JOptionPane.showMessageDialog(dialog, "Thêm thành công");
                                        dialog.dispose();
                                    }
                                    
                              }
                              
                          }
                        });
        CacelBtn.addActionListener(new ActionListener() { 
                          public void actionPerformed(ActionEvent e) { 
                              dialog.dispose();
                          }
                        });
        dialog.getContentPane().setLayout(new BorderLayout());
        dialog.getContentPane( ).add(tmncc, BorderLayout.CENTER);
        dialog.getContentPane( ).add(jp, BorderLayout.SOUTH);
        dialog.setModal(true);
        dialog.pack();
        dialog.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        dialog.setLocationRelativeTo(null);
        
        dialog.setVisible(true);
        dialog.addWindowListener(new WindowAdapter()
        {
            public void windowClosing (WindowEvent e)
            {
                super.windowClosing(e);
            }
        });
    }//GEN-LAST:event_ThemNCCBtnMouseClicked

    private void GiaGocTxtKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_GiaGocTxtKeyTyped
        if(!(Character.isDigit(evt.getKeyChar()))){
                evt.consume();
            }
        long num =0;
        try{
            num = Long.parseLong(GiaGocTxt.getText());
        }
        catch(Exception e){
            
        }
        
        if(num>Integer.MAX_VALUE){
            JOptionPane.showMessageDialog(this, "Giá rất cao");
            GiaGocTxt.setText(Integer.toString(Integer.MAX_VALUE));
        }
    }//GEN-LAST:event_GiaGocTxtKeyTyped

    private void PhanTramGiamGiaTxtKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_PhanTramGiamGiaTxtKeyTyped
        if(!(Character.isDigit(evt.getKeyChar()))){
                evt.consume();
            }
        int num= 0;
        try{
            num = Integer.parseInt(PhanTramGiamGiaTxt.getText());
        }
        catch(Exception e){
            
        }
        
        if(num>10){
            JOptionPane.showMessageDialog(this, "Phần trăm giảm giá không quá 100");
            PhanTramGiamGiaTxt.setText("100");
            evt.consume();
        }
    }//GEN-LAST:event_PhanTramGiamGiaTxtKeyTyped
    public void LoadMaDMCBox(){
        try{
            ResultSet r = new DBUpdater().LayMaDM();
            while (r.next()){
                String madm = r.getString("MaDM");
                MaDMCBox.addItem(madm);
            } 
            
        }catch(Exception e){
            e.printStackTrace();
        }
    }
    public void LoadMaNCCCBox(){
        try{
            ResultSet r = new DBUpdater().LayMaNCC();
            while (r.next()){
                String mancc = r.getString("MaNCC");
                MaNCCCBox.addItem(mancc);
            } 
            
        }catch(Exception e){
            e.printStackTrace();
        }
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    public javax.swing.JTextField GiaGocTxt;
    public javax.swing.JComboBox<String> MaDMCBox;
    public javax.swing.JComboBox<String> MaNCCCBox;
    public javax.swing.JTextField MaSPTxt;
    public javax.swing.JTextArea MotaTxt;
    public javax.swing.JTextField PhanTramGiamGiaTxt;
    public javax.swing.JTextField TenSPTxt;
    private javax.swing.JButton ThemDMBtn;
    private javax.swing.JButton ThemNCCBtn;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JScrollPane jScrollPane2;
    // End of variables declaration//GEN-END:variables
}
