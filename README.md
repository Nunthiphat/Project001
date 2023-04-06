ความเป็นมา
```
เนื่องจากการบริหารราคาร้านอาหารหรือร้านค้าค่อนข้างสำคัญจึงสร้างแอพขึ้นเพื่อการบันทึกราคาและกำหนดสิทธิในการเข้าถึงข้อมูล
```
วัตถุประสงค์
```
กำหนดขอบเขตของการเข้าถึงข้อมูลระหว่างผู้บริหารและลูกจ้างในการเข้าถึงข้อมูลราคาสินค้าโดยมีการยืนยันตัวตนด้วยการล็อคอินซึ่งผู้บริหารหรือ Admin ก็จะสามารถกำหนดราคาสินค้าได้ ส่วนพนักงานลูกจ้างก็จะมีสิทธิเพียงการดูข้อมูล
```
โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
 Class Diagram
 ```mermaid
 classDiagram
  class Login{
  +userData:userData
  +Namedata:string
  +Roledata:string
  +Passcheck:bool
  -loginBtn_Click():void
  }
  class userData{
  +Name:string
  +Username:string
  +Password:string
  -checkPass():bool
  }
  class Admin{
  -button1_Click():void
  -getProducts():Products
  -LoadCSV():List<Products>
  -saveToolStripMenuItem_Click():void
  -BindData():void
  -load_Click():void
  }
  class employee{
  -openToolStripMenuItem_Click():void
  -load_Click():void
  -BindData():void
  }
  class Product{
    +pdname:string
    +pdPrice:int
    -getpdName():string
    -getpdPrice():string
 }

 Login <|-- Admin
 Login <|-- employee
 Login <|-- userData
 Admin <|-- Product
 employee <|-- Product

```
ชื่อผู้พัฒนา
```
นายนันทิพัฒน์ บุตรวัง 653450094-8
```