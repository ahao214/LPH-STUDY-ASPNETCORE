using static System.Console;

Title = "协变和逆变";

/*
泛型中的协变和逆变
 */

#region 协变

// 发生在泛型中,并且是关于子类和父类关系
Animal a1 = new Animal();
Dog d1 = new Dog();
Animal a2 = new Dog();


// 协变 在泛型中子类变量可以赋值给父类变量
Factory<Dog> fac = MakeDog;
Factory<Animal> fac2 = fac;


#endregion


#region 逆变

// 在泛型中关于父子之间方法参数(初始化泛型的方法)的问题
// 逆变:在泛型中、父类作为方法参数、父类变量--->子变量 时的情况
Action1<Animal> act1 = ActionAnimal;
Action1<Dog> act2 = act1;

#endregion



static Dog MakeDog()
{
    return new Dog();
}

static void ActionAnimal(Animal a)
{

}


delegate T Factory<out T>();

delegate void Action1<in T>(T value);




class Animal
{

}

class Dog : Animal
{

}