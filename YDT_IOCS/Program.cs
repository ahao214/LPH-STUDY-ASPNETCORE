using YDT_IOCS.IOCS;
using static System.Console;

Title = "IOC源码";


// 创建IOCFactory
IOCFactory iOCFactory = new IOCFactory();

// 创建对象
Student stu = (Student)iOCFactory.GetObject("YDT_IOCS.IOCS.Student");

// 使用student
stu.Study();

Teacher tea = (Teacher)iOCFactory.GetObject("YDT_IOCS.IOCS.Teacher");
tea.Classes();

ReadKey();












