## Primitive Types and Expression
### Variables and Constants
- **variable**: name that we give to storage location on memory
- **constant**: immutable value
Define a variable:
```
type identifier;
```
**Note**: variable need to assigned first in order to use it.

Primitive Type:
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/BlogImages/09152017113244AM/datatypes.PNG)

Identifier naming convention:
- Pascal Case (for constant value)
```
string FirstName;
```
- Camel Case (for local variable)
```
string firstName;
```
- If name same as reserve keyword
```
int @int = 1;
```

### Type Conversion
Type conversion doesn't affect the original variable because in C# once you declare the type of the variable, you can't change it.
- if types are compatible and target type is bigger, it will be convert automatically.
```
byte b = 1;
int i = b;
```
- if types are compatible and target type is smaller, compiler will give error message which mean it results in bit lose. If you are sure that isn't the case, you can covert like this:
```
int i = 1;
byte b = (byte) i;
```
- if types are not compatible, you need to use Convert class.
```
string s = “1234”;
int i = Convert.ToInt32(s);
```

### Operator
![alt text](https://i0.wp.com/blog.submain.com/wp-content/uploads/2019/04/operators_table_2.png?resize=1500%2C1941&ssl=1)