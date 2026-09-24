This is a dotnet api project.

## ขั้นตอนการทำงานผ่าน Github

- `git checkout -b <branch_name>` สร้าง branch ใหม่ในการทำงานทุกครั้ง 
- `git add .` หลังจากแก้ไขหรือทำงานเสร็จ

### สั่ง commit
- สั่งผ่าน agent / มี skills สำหรับ commit and push ไว้แล้ว (claude)
- `git commit -m "<commit message>"` สั่งผ่าน command.
- `git push -u origin <branch_name>` สั่ง push ผ่าน command.


## Pull Request

- สร้าง pull request ผ่านเว็บ Github แล้วรอ approve
- **approved แล้วให้ลบ branch ได้เลย**
- **`git branch -D <branch_name>` ลบ branch ในเครื่องด้วย**

## Run Dev
run api as swagger
```bash
dotnet run
```

## Settings
1. Connection string ถูกเก็บแบบ secret เรียกดูได้โดย `dotnet user-secrets list`
2. ตั้งค่า Connection String ใหม่ด้วย `dotnet user-secrets list
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<value>"` โดย value = ConnectionString ปกติ

___
