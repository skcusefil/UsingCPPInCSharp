//NativeDll.cpp

#include <string.h>
#include <windows.h>
#include <iostream>

extern "C"             
__declspec(dllexport)  
void                    
__cdecl                

    test() {
    double number;

    std::cout << "EZ function from C++\n";
    std::cout << "Enter number: ";
    std::cin >> number;
    std::cout << number << "+" << number << "=" << number + number;

}

extern "C" __declspec(dllexport) void Hello()
{
    std::cout << "Hello C# from C++";
}