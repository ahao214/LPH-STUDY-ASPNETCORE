﻿using static System.Console;

Title = "Lambda表达式";


// 无参数无返回值
Action action = () => WriteLine("无参数无返回值的Lambda");
action();


// 有参数无返回值Lambda
Action<string> action1 = msg => WriteLine(msg);
action1("有参数无返回值Lambda");

























