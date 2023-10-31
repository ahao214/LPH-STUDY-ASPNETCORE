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



#endregion



static Dog MakeDog()
{
    return new Dog();
}



delegate T Factory<out T>();


class Animal
{

}

class Dog : Animal
{

}