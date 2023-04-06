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
  -loginBtn_Click():void
  -ReadLine():void
  -Split():void
  -checkPass():void
  -Show():void
  -WriteLine():void
  -ToString():void
  }
  class userData{
  -WriteLine():void
  -ReadLine():void
  -Split():void
  -Equals():void
  -ToString():string
  -checkPass():bool
  }
  class admin{
  -couponCode:string
  -minimumPice:double
  +creat(double min):void
  +getCoupon():void
  }
  class employee{
  -totalPice:double
  +Bill(pay double,getmoney Double):void
  +payBill():double
  }
  class Product{
    +string pdName
    +int pdPrice
    -getpdName()
    -getpdPrice()
 }

```
