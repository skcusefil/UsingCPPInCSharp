Using C++ Dll in C#

1. Create C++ Project

2. export function with 
<code>
extern "C" __declspec(dllexport) void MyFunction
</code>

3. Create C# Project

4. Create a class in C# Project for imporint dll from C++
<code>
[DllImport(path, CallingConvention = CallingConvention.Cdecl)]

public extern static void MyFunction();
</code>

"path" is a string type, which is dll file name

5. Test function!
