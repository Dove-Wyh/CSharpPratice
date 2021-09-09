#include <iostream>

class MyClass
{
public:
	MyClass()
	{
		std::cout << "默认的无参构造函数" << std::endl;
	}

	~MyClass()
	{
		std::cout << "析构函数" << std::endl;
	}

	MyClass(const char* data)
	{
		std::cout << "带参构造函数" << std::endl;
		if (data == nullptr)
		{
			std::cout << "参数是空指针1" << std::endl;
			return;
		}
		int length = strlen(data) + 1;
		this->data = new char[strlen(data) + 1];
		strcpy_s(this->data, length, data);
	}

	MyClass(const MyClass& myClass)
	{
		std::cout << "拷贝构造函数" << std::endl;
		if (&myClass == nullptr)
		{
			std::cout << "参数是空指针2" << std::endl;
			return;
		}
		if (myClass.data == nullptr)
		{
			std::cout << "参数是空指针3" << std::endl;
			return;
		}
		int length = strlen(myClass.data) + 1;
		this->data = new char[strlen(myClass.data) + 1];
		strcpy_s(this->data, length, myClass.data);
	}

	MyClass& operator=(const MyClass& myClass)
	{
		std::cout << "=运算符重载" << std::endl;
		if (this == &myClass)
		{
			std::cout << "传进来的是自身" << std::endl;
			return *this;
		}
		if (this->data != nullptr)
		{
			std::cout << "删除之前存在的东西,防止内存泄漏" << std::endl;
			delete[] this->data;
			this->data = nullptr;
		}
		int length = strlen(myClass.data) + 1;
		this->data = new char[strlen(myClass.data) + 1];
		strcpy_s(this->data, length, myClass.data);
		return *this;
	}

private:
	char* data = nullptr;
};


int main()
{
	char s[] = { 'qwe' };
	MyClass c1(s);			//"带参构造函数"
	MyClass c2(c1);			//"拷贝构造函数"
	MyClass c3 = c2;		//"拷贝构造函数"
	MyClass c4 = c3;		//"拷贝构造函数"
	c4 = c3;				//"=运算符重载"
							//"删除之前存在的东西,防止内存泄漏"
	MyClass c5(nullptr);	//"带参构造函数"
							//"参数是空指针1"
	MyClass c6;				//"默认的无参构造函数"
	MyClass c7(c6);			//"拷贝构造函数"
							//"参数是空指针3"
	MyClass* c8;
	c8 = new MyClass();		//"默认的无参构造函数"
	delete c8;				//"析构函数"
	c8 = nullptr;
	MyClass c9(*c8);		//"拷贝构造函数"
							//"参数是空指针2"

	

	int* a = new int;
	int* b = a;
	delete a;
	a = nullptr;

	int c = 1;
	int* d;
	d = &c;
	delete d;
	d = nullptr;
}


